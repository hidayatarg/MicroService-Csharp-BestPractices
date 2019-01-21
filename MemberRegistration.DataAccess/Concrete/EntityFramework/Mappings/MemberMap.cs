using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberRegistration.Entities.Concrete;

namespace MemberRegistration.DataAccess.Concrete.EntityFramework.Mappings
{
    public class MemberMap:EntityTypeConfiguration<Member>
    {
        public MemberMap()
        {
            ToTable(@"Members", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.DateofBirth).HasColumnName("DateofBirth");
            Property(x => x.Email).HasColumnName("Email");
            Property(x => x.FirstName).HasColumnName("FirstName");
            Property(x => x.LastName).HasColumnName("LastName");
            Property(x => x.Email).HasColumnName("Email");
           
        }
    }
}
