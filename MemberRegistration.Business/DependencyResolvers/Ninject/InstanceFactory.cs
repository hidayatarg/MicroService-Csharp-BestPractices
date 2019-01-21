using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Utilities.Mappings;
using Ninject;

namespace MemberRegistration.Business.DependencyResolvers.Ninject
{
    // For integration of WinForm /WP
    public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var kernal = new StandardKernel(new BusinessModule());
            return kernal.Get<T>();
        }
    }
}
