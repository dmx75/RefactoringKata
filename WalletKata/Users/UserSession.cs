using WalletKata.Exceptions;

namespace WalletKata.Users
{
    public class UserSession
    {
        private static volatile UserSession userSession;
        private static object myLock = new object();

        private UserSession() { }

        public static UserSession GetInstance()
        {
            if (userSession == null)
            {
                lock (myLock)
                {
                    if (userSession == null)
                        userSession = new UserSession();
                }
            }

            return userSession;
        }

        public IUser GetLoggedUser()
        {
            throw new ThisIsAStubException("UserSession.IsUserLoggedIn() should not be called in an unit test");
        }
    }
}