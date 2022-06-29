using Autofac;
using AutoMapper;
using Brainlaw.Application;
using Brainlaw.Application.Interfaces;
using Brainlaw.Application.Mappers;
using Brainlaw.Domain.Core.Interfaces.Repositories;
using Brainlaw.Domain.Core.Interfaces.Services;
using Brainlaw.Domain.Services;
using Brainlaw.Infrastructure.Data.Repositories;

namespace Brainlaw.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DtoToModelMappingProduto());
                cfg.AddProfile(new ModelToDtoMappingProduto());

            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();
        }

        #endregion IOC
    }

}