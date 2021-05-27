
namespace BasicFramework.Framework.Models
{
    public class User
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public static User GetDefaultUser()
        {
            return new User { Login = "standard_user", Password = "secret_sauce" };
        }
    }
}