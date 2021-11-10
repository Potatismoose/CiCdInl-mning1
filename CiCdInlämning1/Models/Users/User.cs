using CiCdInlämning1.Interfaces;
using System;

namespace CiCdInlämning1.Models.Users
{
    [Serializable]
    public class User : Account, ISaveable
    {
        public User(int id, string name, string password, string email, int salary) : base(id, name, password, email, salary)
        {

        }
        
    }
}
