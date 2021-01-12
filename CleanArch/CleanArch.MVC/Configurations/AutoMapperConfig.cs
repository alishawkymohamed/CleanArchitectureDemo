using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.MVC.Configurations
{
    public static class AutoMapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CleanArch.Application.AutoMapper.AutoMapperConfig));
            CleanArch.Application.AutoMapper.AutoMapperConfig.RegisterMappings();
        }
    }
}
