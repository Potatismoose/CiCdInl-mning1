using System;

namespace CiCdInlämning1.Models.Users
{
    public abstract class Account
    {
        //Main parent.

        public Account(int id, string name, string password, string email, bool isAdmin = false)
        {
            Id = id;
            Name = name;
            Password = password;
            Email = email;
            IsAdmin = isAdmin;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }

        public override string ToString()
        {
            return ($"{Name}, Har adminbehörighet: {IsAdmin}");
        }
    }
}
