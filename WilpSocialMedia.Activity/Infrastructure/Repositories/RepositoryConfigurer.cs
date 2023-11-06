using WilpSocialMedia.Activity.Domain.Model.Repositories.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilpSocialMedia.Activity.Infrastructure.Repositories
{
    public class RepositoryConfigurer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IFriendRequestRepository, FriendRequestRepository>();
            services.AddTransient<IFriendRelationshipRepository, FriendRelationshipRepository>();
            services.AddTransient<IActivityStatusRepository, ActivityStatusRepository>();
        }
    }
}
