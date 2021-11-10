using CiCdInlämning1.Models.Users;
using NUnit.Framework;

namespace CiCdInlämning1.Controllers.Tests
{
    [TestFixture()]
    public class LoginControllerTests
    {
        [TestCase("S/M Bosse", "HejGummiBralla", TestName = "Login_InvalidUsername_ReturnNull")]
        [TestCase(null, "HejGummiBralla", TestName = "Login_NullUsername_ReturnNull")]
        [TestCase("S/M Bosse", null, TestName = "Login_NullPassword_ReturnNull")]
        [TestCase(null, null, TestName = "Login_NullPasswordAndNullUsername_ReturnNull")]
        public void LoginTestFail(string userName, string password)
        {
            //Act
            var result = LoginController.Login(userName, password);
            //Assert
            Assert.That(result, Is.Null);
        }

        [TestCase("Bertil Karlsson", "Gurka531", TestName = "Login_ValidUsername_ReturnUser")]
        [TestCase("Anders Donick", "Banan554", TestName = "Login_ValidUsername_ReturnAdmin")]
        public void LoginTestSuccessful(string userName, string password)
        {
            //Act
            var result = LoginController.Login(userName, password);
            //Assert
            Assert.That(result, Is.InstanceOf<Account>());
            
        }
    }
}