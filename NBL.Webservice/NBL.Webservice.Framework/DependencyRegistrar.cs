using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using NBL.Webservice.DataAccess;
using System.Configuration;
using Autofac.Integration.Mvc;
using NBL.WebService.Service;
using NBL.WebService.Domain;

namespace NBL.Webservice.Framework
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        
       

        public static class ContainerConfig
        {
            public static IContainer Configure()
            {
                var builder = new ContainerBuilder();
                var tera = ConfigurationManager.AppSettings["Connectionstring"];
                builder.Register<IDbContext>(c => new WebServiceObjectContext(ConfigurationManager.AppSettings["Connectionstring"])).InstancePerLifetimeScope();

                builder.RegisterType<HospitalService>().As<IHospitalService>().InstancePerLifetimeScope();
                builder.RegisterType<Repository<Hostpital>>().As<IRepository<Hostpital>>().InstancePerLifetimeScope();

                return builder.Build();
            }
        }

        public void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
           builder.RegisterControllers(typeFinder.GetAssemblies().ToArray());          



        }

   
    }
}

