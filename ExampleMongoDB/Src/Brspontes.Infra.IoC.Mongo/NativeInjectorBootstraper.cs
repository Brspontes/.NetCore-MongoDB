using AutoMapper;
using Brspontes.Domain.Service.Mongo.HeroesContext.AutoMapper;
using Brspontes.Domain.Service.Mongo.HeroesContext.Contract;
using Brspontes.Domain.Service.Mongo.HeroesContext.Handle;
using Brspontes.Infra.Mongo.MongoContext;
using Brspontes.Infra.Mongo.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Brspontes.Infra.IoC.Mongo
{
    public class NativeInjectorBootstraper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IRepository, HeroesRepository>();
            services.AddScoped<RepositoryConnection, RepositoryConnection>();
            services.AddScoped<HeroesHandle, HeroesHandle>();
            services.AddSingleton<IConfigurationProvider>(AutoMapperConfiguration.RegisterMappings());
            services.AddScoped<IMapper>(sp =>
            new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));
        }
    }
}
