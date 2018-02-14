using System.Collections.Generic;
using WalletKata.Users;
using WalletKata.Exceptions;
using System;

namespace WalletKata.Wallets
{
    public class WalletService
    {
        public List<Wallet> GetWalletsByUser(IUser user, IUser loggedUser)
        {
            if (user == null)
                throw new ArgumentNullException("user");

            if (loggedUser == null)
                throw new UserNotLoggedInException();

            var walletDao = new WalletDAO();

            List<Wallet> walletList = new List<Wallet>();
            //IUser loggedUser = UserSession.GetInstance().GetLoggedUser();

            if (user.IsFriendWith(loggedUser))
            {
                return walletDao.FindWalletsByUser(user);
            }

            return walletList;
        }
    }
}