using CiCdInl�mning1.Controllers;
using CiCdInl�mning1.Models.Users;
using CiCdInl�mning1.Utilities;
using NUnit.Framework;

namespace IntegrationTests
{
    public class Tests
    {
        public void CreateLoginRemoveUser()
        {
            //Arrage

            User createdUser = new(
                ReadWrite.ReadLastEmployeeIdFromFile() + 1,
                "Helge",
                "Gubbstrutt",
                "helge@fullgubbe.nu",
                12000,
                "Vaktm�stare"
                );


            //Act
            var loggedInUser = LoginController.Login("admin1", "admin1234");
            ReadWrite.Serialize(createdUser);
            ReadWrite.ReadFromFilesAndAddToListOfUsersAndUpdateEmployeeId();
            var listOfUsers = ReadWrite.GetListOfUsers();

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(loggedInUser, Is.InstanceOf<Account>());
                Assert.That(listOfUsers, Contains.Item(createdUser));
            });
        }
    }
}