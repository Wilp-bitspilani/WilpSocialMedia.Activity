using WilpSocialMedia.Common.API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilpSocialMedia.Activity.Application.DTO
{
    public class ListFriendRequest
    {
        public Guid IdRequest { get; set; }
        public AccountUserDto UserSender { get; set; }
        public AccountUserDto UserReciever { get; set; }
        public string Status { get; set; }
    }
}
