using WilpSocialMedia.Common.Repositories;
using WilpSocialMedia.Common.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilpSocialMedia.Activity.Domain.Model.Repositories.Interface
{
    public interface IFriendRelationshipRepository : IEfRepository<FriendRelationship>
    {
    }
}
