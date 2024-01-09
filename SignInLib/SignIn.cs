namespace SignInLib
{
    public class SignIn
    {
        public static string Authenticate(string username, string password)
        {
            string result;
            if(string.IsNullOrEmpty(username)|| string.IsNullOrEmpty(password))
            {
                result = "you must provide username and password";
            } 
            else if(username == "sam" || password == "sam@1256")
            {
                result = "Valid user";
            }
            else
            {
                result = "invalid user";
            }
            return result;
        }
    }
}