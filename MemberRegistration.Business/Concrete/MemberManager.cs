using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Aspects.Postsharp.ValidationAspects;
using MemberRegistration.Business.Abstruct;
using MemberRegistration.Business.ServiceAdapters;
using MemberRegistration.Business.ValidationRules.FluentValidation;
using MemberRegistration.DataAccess.Abstruct;
using MemberRegistration.Entities.Concrete;

namespace MemberRegistration.Business.Concrete
{
    public class MemberManager:IMemberService
    {
        // Need access to DataAccess Layer
        private IMemberDal _memberDal;
        private IKpsService _kpsService;

        public MemberManager(IMemberDal memberDal, IKpsService kpsService)
        {
            _memberDal = memberDal;
            _kpsService = kpsService;
        }

        [FluentValidationAspect(typeof(MemberValidator))]
        public void Add(Member member)
        {
            // Islem(Actions)
            // Check if there is a record on same TC
            if (_memberDal.Get(m => m.TcNo == member.TcNo) != null)
            {
                throw new Exception("Bu Kullanici daha once Kayit olmustur.");
            }

            // Check the member from kimlik dogrula 
            if (_kpsService.ValidateUser(member) == false)
            {
                throw new Exception("Kullanici dogrulamasi gecerli degil");
            }

           _memberDal.Add(member);
        }
    }
}
