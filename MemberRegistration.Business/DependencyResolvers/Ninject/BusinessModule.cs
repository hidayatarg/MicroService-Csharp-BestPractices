using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberRegistration.Business.Abstruct;
using MemberRegistration.Business.Concrete;
using MemberRegistration.Business.ServiceAdapters;
using MemberRegistration.DataAccess.Abstruct;
using MemberRegistration.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace MemberRegistration.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            // If IMemberService is Requested give MemberManager
            Bind<IMemberService>().To<MemberManager>().InSingletonScope();
            Bind<IMemberDal>().To<EfMemberDal>().InSingletonScope();

            // Adapter
            Bind<IKpsService>().To<KpsServiceAdapter>().InSingletonScope();
        }
    }
}
