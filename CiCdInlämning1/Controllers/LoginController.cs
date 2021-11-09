using CiCdInlämning1.Interfaces;
using CiCdInlämning1.Models.Users;
using System.Collections.Generic;

namespace CiCdInlämning1.Controllers
{
    public static class LoginController
    {
        public static ISaveable Login(string username, string password)
        {
            if (username is null || password is null)
            {
                return null;
            }
            else
            {
                List<ISaveable> listOfUsers = new() { new User(), new User() }; //TODO: ska använda sig av readwrite getlistofusers.
                return null; //TODO: Returnerar inte korrekt
            }
        }
    }
}
