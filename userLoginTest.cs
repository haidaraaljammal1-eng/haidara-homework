using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserLogin;

namespace UserLogin.Tests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void Login_EmptyUsername_ReturnsFalse()
        {
            var user = new User { Name = "alice", Password = "secret" };
            var result = user.Login("", "secret");

            Assert.IsFalse(result);
            Assert.IsFalse(user.IsLoggedIn);
        }

        [TestMethod]
        public void Login_WhitespaceUsername_ReturnsFalse()
        {
            var user = new User { Name = "alice", Password = "secret" };
            var result = user.Login("   ", "secret");

            Assert.IsFalse(result);
            Assert.IsFalse(user.IsLoggedIn);
        }

        [TestMethod]
        public void Login_EmptyPassword_ReturnsFalse()
        {
            var user = new User { Name = "alice", Password = "secret" };
            var result = user.Login("alice", "");

            Assert.IsFalse(result);
            Assert.IsFalse(user.IsLoggedIn);
        }

        [TestMethod]
        public void Login_InvalidUsernameValidPassword_ReturnsFalse()
        {
            var user = new User { Name = "alice", Password = "secret" };
            var result = user.Login("wrongUser", "secret");

            Assert.IsFalse(result);
            Assert.IsFalse(user.IsLoggedIn);
        }

        [TestMethod]
        public void Login_ValidUsernameInvalidPassword_ReturnsFalse()
        {
            var user = new User { Name = "alice", Password = "secret" };
            var result = user.Login("alice", "wrongPass");

            Assert.IsFalse(result);
            Assert.IsFalse(user.IsLoggedIn);
        }

        [TestMethod]
        public void Login_ValidUsernameAndPassword_ReturnsTrueAndSetsIsLoggedIn()
        {
            var user = new User { Name = "alice", Password = "secret" };
            var result = user.Login("alice", "secret");

            Assert.IsTrue(result);
            Assert.IsTrue(user.IsLoggedIn);
        }
    }
}