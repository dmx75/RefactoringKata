using Moq;
using NUnit.Framework;
using WalletKata.Exceptions;
using WalletKata.Users;
using WalletKata.Wallets;

namespace WalletKata.Test
{
    [TestFixture]
    public class WalletServiceTest
    {
        Mock<WalletDAO> daoMock;

        [SetUp]
        public void SetUp()
        {
            daoMock = new Mock<WalletDAO>();
        }

     
        //[Test]
        //public void get_wallet_by_user_friend()
        //{ 
        //    //Mock 
        //    daoMock.Setup(m => m.FindWalletsByUser(It.IsAny<User>())).Returns(new List<Wallet> { new Wallet(), new Wallet() });
          
        //    var walletService = new WalletService();

        //    //Users
        //    var user = new User();
        //    var loggedUser = new User();
        //    user.AddFriend(loggedUser);          

        //    var wallets = walletService.GetWalletsByUser(user, loggedUser);

        //    Assert.AreEqual(wallets.Count, 2);
        //}

        /// <summary>
        /// User and loggerUser are NOT friends
        /// </summary>
        [Test]
        public void get_wallet_by_user_friend_throws_ThisIsAStubException()
        {
            var walletService = new WalletService();

            //Users
            var user = new User();
            var loggedUser = new User();
            user.AddFriend(loggedUser);

            Assert.Throws(typeof(ThisIsAStubException), () => walletService.GetWalletsByUser(user, loggedUser));
        }

        /// <summary>
        /// User and loggerUser are NOT friends
        /// </summary>
        [Test]
        public void get_wallet_by_user_not_friend()
        {
            var walletService = new WalletService();

            //Users
            var user = new User();
            var loggedUser = new User();

            var wallets = walletService.GetWalletsByUser(user, loggedUser);

            Assert.AreEqual(wallets.Count, 0);
        }
        
        [Test]
        public void get_wallet_by_user_not_logged_throws_UserNotLoggedInException()
        {  
            var walletService = new WalletService();
           
            var user = new User();
            Assert.Throws(typeof(UserNotLoggedInException), () => walletService.GetWalletsByUser(user, null));
        }
    }
}
