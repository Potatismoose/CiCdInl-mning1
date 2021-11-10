using System;

namespace CiCdInlämning1.Models.Users
{

    [Serializable]
    public class Admin : User
    {
        public Admin(int id, string name, string password, string email, int salary) : base(id, name, password, email, salary)
        {
            base.IsAdmin = true;
        }
    }
}
