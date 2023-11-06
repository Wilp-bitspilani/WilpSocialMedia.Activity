using System;
using System.Collections.Generic;

namespace WilpSocialMedia.Activity.Domain.Model
{
    public partial class FriendRequest
    {
        public FriendRequest()
        {
            FriendRelationship = new HashSet<FriendRelationship>();
        }

        public Guid Id { get; set; }
        public Guid UserSender { get; set; }
        public Guid UserReciever { get; set; }
        public Guid? Status { get; set; }

        public virtual ActivityStatus StatusNavigation { get; set; }
        public virtual ICollection<FriendRelationship> FriendRelationship { get; set; }
    }
}