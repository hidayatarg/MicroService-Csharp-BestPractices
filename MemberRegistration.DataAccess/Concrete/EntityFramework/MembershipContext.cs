using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberRegistration.Entities.Concrete;

namespace MemberRegistration.DataAccess.Concrete.EntityFramework
{
    public class MembershipContext:DbContext
    {
        public DbSet<Member> Members { get; set; }
    }
}
