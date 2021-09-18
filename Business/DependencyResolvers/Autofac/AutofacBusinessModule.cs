using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DirectoryContext>().As<DbContext>();

            builder.RegisterType<EfContactManager>().As<IContactService>();
            builder.RegisterType<EfContactDal>().As<IContactDal>();

            builder.RegisterType<EfPhoneManager>().As<IPhoneService>();
            builder.RegisterType<EfContactDal>().As<IContactDal>();

            builder.RegisterType<EfLocationManager>().As<ILocationService>();
            builder.RegisterType<EfContactDal>().As<IContactDal>();

            builder.RegisterType<EfContactManager>().As<IContactService>();
            builder.RegisterType<EfEmailDal>().As<IEmailDal>();
        }
    }
}
