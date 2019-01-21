using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberRegistration.Business.Abstruct;
using MemberRegistration.Business.ServiceAdapters;
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
        public void Add(Member member)
        {
            // Islem(Actions)

            // Check the member from kimlik dogrula 
            if (_kpsService.ValidateUser(member) == false)
            {
                throw new Exception("Kullanici dogrulamasi gecerli degil");
            }

           _memberDal.Add(member);
        }
    }
}
