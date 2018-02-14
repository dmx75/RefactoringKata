using System.Collections.Generic;

namespace WalletKata.Users
{
    public class User : IUser
    {
        private List<IUser> friends = new List<IUser>();

        public List<IUser> GetFriends()
        {
            return friends;
        }

        public int GetFriendsCount()
        {
            return friends.Count;
        }

        public void AddFriend(IUser friend)
        {
            if (friend != null)
            {
                friends.Add(friend);
            }
        }

        public bool IsFriendWith(IUser user)
        {
            bool isFriend = false;
            if (user != null)
            {
                foreach (IUser friend in GetFriends())
                {
                    if (friend.Equals(user))
                    {
                        isFriend = true;
                        break;
                    }
                }
            }

            return isFriend;
        }
    }
}