using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberRegistration.Business.Abstruct;
using MemberRegistration.DataAccess.Abstruct;
using MemberRegistration.Entities.Concrete;

namespace MemberRegistration.Business.Concrete
{
    public class MemberManager:IMemberService
    {
        // Need access to DataAccess Layer
        private IMemberDal _memberDal;

        public MemberManager(IMemberDal memberDal)
        {
            _memberDal = memberDal;
        }
        public void Add(Member member)
        {
           // Islem(Actions)
           _memberDal.Add(member);
        }
    }
}
