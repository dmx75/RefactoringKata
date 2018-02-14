using System.Collections.Generic;

namespace WalletKata.Users
{
    public interface IUser
    {
        List<IUser> GetFriends();
        int GetFriendsCount();
        void AddFriend(IUser friend);
        bool IsFriendWith(IUser user);
    }
}
