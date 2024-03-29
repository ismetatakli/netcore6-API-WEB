﻿using Autofac;
using Core6App.Core.Repositories;
using Core6App.Core.Services;
using Core6App.Core.UnitOfWorks;
using Core6App.Repository;
using Core6App.Repository.Repositories;
using Core6App.Repository.UnitOfWorks;
using Core6App.Service.Mappings;
using Core6App.Service.Services;
using System.Reflection;
using Module = Autofac.Module;
namespace Core6App.Web.Modules
{
    public class RepoServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            var apiAssembly = Assembly.GetExecutingAssembly();
            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));
            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Service"))
                .AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
