using WilpSocialMedia.Activity.Application;
using WilpSocialMedia.Activity.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilpSocialMedia.Activity
{
    public static class MainBootsraper
    {
        public static void InitAppBootsraper(this IServiceCollection services)
        {
            RepositoryConfigurer.RegisterServices(services);
            ApplicationConfigurer.RegisterServices(services);
        }
    }
}
