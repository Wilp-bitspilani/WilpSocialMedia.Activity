using WilpSocialMedia.Activity.Domain.Model;
using WilpSocialMedia.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilpSocialMedia.Activity.Infrastructure.Repositories.Extensions
{
    public static class FriendRequestRepositoryExtension
    {
        public static IEnumerable<FriendRequest> FilterRelationship(this IEnumerable<FriendRequest> query)
        => query.Where(x => x.StatusNavigation.Name.Equals(Global.Status.Accepted) &&
                   x.FriendRelationship.Any(y => y.StatusNavigation.Name.Equals(Global.Status.Accepted)));

        public static IEnumerable<FriendRequest> FilterRequest(this IEnumerable<FriendRequest> query)
        => query.Where(x => x.StatusNavigation.Name.Equals(Global.Status.Request) &&
                   x.FriendRelationship.Any(y => y.StatusNavigation.Name.Equals(Global.Status.Pending)));


    }
}
