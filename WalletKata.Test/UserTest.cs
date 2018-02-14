using NUnit.Framework;
using WalletKata.Users;

namespace WalletKata.Test
{
    public class UserTest
    {
        [Test]
        public void add_friend()
        {
            var user1 = new User();
            var user2 = new User();

            Assert.AreEqual(user1.GetFriendsCount(), 0);

            user1.AddFriend(user2);

            Assert.AreEqual(user1.GetFriendsCount(), 1);
        }

        [Test]
        public void add_friend_null()
        {
            var user1 = new User();           

            Assert.AreEqual(user1.GetFriendsCount(), 0);

            user1.AddFriend(null);

            Assert.AreEqual(user1.GetFriendsCount(), 0);
        }

        [Test]
        public void is_friend()
        {
            var user1 = new User();
            var user2 = new User();

            Assert.AreEqual(user1.IsFriendWith(user2), false);

            user1.AddFriend(user2);

            Assert.AreEqual(user1.IsFriendWith(user2), true);
        }

        [Test]
        public void is_friend_null()
        {
            var user1 = new User();           

            user1.AddFriend(null);

            Assert.AreEqual(user1.IsFriendWith(null), false);
        }
    }
}
