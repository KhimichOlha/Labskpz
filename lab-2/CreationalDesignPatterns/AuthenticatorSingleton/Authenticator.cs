namespace AuthenticatorSingleton
{
    public class Authenticator
    {
        private static Authenticator singleton;
        private Authenticator()
        {

        }
        public static Authenticator GetInstance()
        {
            if (singleton == null)
            {
                singleton = new Authenticator();
            }
            return singleton;
        }
        public string Authenticate(string username, string password)
        {
            return $"Authenticating user: {username}";

        }
    }
}
