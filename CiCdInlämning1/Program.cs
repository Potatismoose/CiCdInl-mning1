using CiCdInlämning1.Models.Users;
using System;

namespace CiCdInlämning1
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new(1, "John Doe", "Testar123", "testarigen@test.com");
            Admin admin = new(1, "John Doe", "Testar123", "testarigen@test.com");
            Console.WriteLine(admin.IsAdmin);
            Console.ReadKey();
        }
    }
}
