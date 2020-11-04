using Autofac;
using LinkedBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListUI.Container
{
    public static class ContainerConfig
    {
        /// <summary>
        /// Container for setup of Interfaces Registering
        /// </summary>
        /// <returns></returns>
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<LinkedListMaster>().As<ILinkedListMaster>();
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(LinkedBusiness)))
                .Where(t => t.Namespace.Contains("Utilities"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }

    }
}
