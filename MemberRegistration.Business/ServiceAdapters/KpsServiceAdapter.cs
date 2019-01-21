using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberRegistration.Business.KpsServiceReference;
using MemberRegistration.Entities.Concrete;

namespace MemberRegistration.Business.ServiceAdapters
{
    public class KpsServiceAdapter:IKpsService
    {
        public bool ValidateUser(Member member)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula( Convert.ToInt64(member.TcNo),member.FirstName.ToUpper(),
                member.LastName.ToUpper(), member.DateofBirth.Year);

        }
    }
}
