using WilpSocialMedia.Activity.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace WilpSocialMedia.Activity.Application
{
    public class ApplicationConfigurer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IFriendService, FriendService>();
            
        }
    }
}
