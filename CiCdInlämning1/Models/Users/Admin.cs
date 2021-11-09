using System;

namespace CiCdInlämning1.Models.Users
{
    [Serializable]
    class Admin : User
    {
        public Admin(int id, string name, string password, string email) : base(id, name, password, email)
        {
            base.IsAdmin = true;
        }
    }
}
