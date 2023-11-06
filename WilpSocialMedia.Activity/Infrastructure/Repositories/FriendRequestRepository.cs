using WilpSocialMedia.Activity.Domain.Model;
using WilpSocialMedia.Activity.Domain.Model.Repositories.Interface;
using WilpSocialMedia.Common.Infrastructure.Interface;
using WilpSocialMedia.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilpSocialMedia.Activity.Infrastructure.Repositories
{
    public class FriendRequestRepository : EfRepository<FriendRequest>, IFriendRequestRepository
    {
        private readonly IDbContextFactory _dbContextFactory;
        private readonly Wilpsocialmedia_ActivityContext _context;
        public FriendRequestRepository(Wilpsocialmedia_ActivityContext context, IDbContextFactory dbContextFactory) : base(context)
        {
            _dbContextFactory = dbContextFactory;
            _context = context;
        }

        public bool HasRelated(Guid UserSender, Guid UserReciever)
        {
            throw new NotImplementedException();
        }
    }
    
}
