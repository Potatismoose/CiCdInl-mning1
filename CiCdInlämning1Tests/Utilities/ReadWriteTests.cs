using NUnit.Framework;
using CiCdInlämning1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CiCdInlämning1.Models.Users;
using CiCdInlämning1.Interfaces;

namespace CiCdInlämning1.Utilities.Tests
{
    [TestFixture()]
    public class ReadWriteTests
    {
        [Test()]
        public void GetListOfUsers_Is_not_Null()
        {
            // Act
            ReadWrite.Serialize(new User(1, "Johan", "testar123", "bad@bad.com", 55000));
            ReadWrite.Deserialize();
            // Arrange
            var actual = ReadWrite.GetListOfUsers();
            // Assert
            Assert.That(actual, Is.Not.Null);
        }
    }
}