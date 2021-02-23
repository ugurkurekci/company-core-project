using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBussinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AdminManager>().As<IAdminService>().SingleInstance();
            builder.RegisterType<EfAdminDAL>().As<IAdminDAL>().SingleInstance();

            builder.RegisterType<AuthorizedManager>().As<IAuthorizedService>().SingleInstance();
            builder.RegisterType<EfAuthorizedDAL>().As<IAuthorizedDAL>().SingleInstance();

            builder.RegisterType<CustomerRegistrationManager>().As<ICustomerRegistrationService>().SingleInstance();
            builder.RegisterType<EfCustomerRegistrationDAL>().As<ICustomerRegistrationDAL>().SingleInstance();

            builder.RegisterType<ProductRegistrationManager>().As<IProductRegistrationService>().SingleInstance();
            builder.RegisterType<EfProductRegistrationDAL>().As<IProductRegistrationDAL>().SingleInstance();

            builder.RegisterType<RegionManager>().As<IRegionService>().SingleInstance();
            builder.RegisterType<EfRegionDAL>().As<IRegionDAL>().SingleInstance();

            builder.RegisterType<SoldProductManager>().As<ISoldProductService>().SingleInstance();
            builder.RegisterType<EfSoldProductDAL>().As<ISoldProductDAL>().SingleInstance();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
