using CiCdInlämning1.Interfaces;
using CiCdInlämning1.Models.Users;
using System.Collections.Generic;
using System;

namespace CiCdInlämning1.Utilities
{
    public static class ReadWrite
    {
        static List<ISaveable> listOfUsers = new() {
            new User(
                12,
                "Bertil Karlsson",
                "Gurka531",
                "B.Karlsson@company.com"),
            new Admin(
                1,
                "Anders Donick",
                "Banan554",
                "a.donick@company.com")
        };

        public static void Deserialize()
        {

        }

        public static List<ISaveable> GetListOfUsers()
        {
            return listOfUsers;
        }
    }
}
