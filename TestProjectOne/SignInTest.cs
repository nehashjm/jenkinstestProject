using SignInLib;

namespace TestProjectOne
{
    [TestClass]
    public class SignInTest
    {
   
        [TestMethod]
        public void SuccessMethod()
        {
            string expResult = "Valid user";
            Assert.AreEqual(expResult, SignIn.Authenticate("sam", "sam@1256"));
        }
        [TestMethod]
        public void FailMethod()
        {
            string expResult = "invalid user";
            Assert.AreEqual(expResult, SignIn.Authenticate("ravi", "ravi@123"));
        }
        [TestMethod]
        public void AnonymousMethod()
        {
            string expResult = "you must provide username and password";
            Assert.AreEqual(expResult, SignIn.Authenticate(null, null));
        }
    }
}