using WilpSocialMedia.Activity.Application.DTO;
using WilpSocialMedia.Activity.Domain.Model;
using WilpSocialMedia.Common.API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilpSocialMedia.Activity.Domain.Services
{
    public interface IFriendService
    {
        (bool status, string message) Approve(Guid idRequest);
        (bool status, string message) Request(Guid userSender, Guid userReciever);
        List<AccountUserDto> ListFriendRequest(Guid idAccountUser);
        List<ListFriendRequest> ListRequest();
        List<AccountUserDto> ListFriend(Guid idAccountUser);

    }
}
