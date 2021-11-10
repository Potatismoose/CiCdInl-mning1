using CiCdInlämning1.Models.Users;
using CiCdInlämning1.Utilities;
using System;

using CiCdInlämning1.Menues;

namespace CiCdInlämning1
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadWrite.Deserialize();
            
            ReadWrite.Serialize(new User(1, "Johan", "testar123", "bad@bad.com"));
            foreach (var item in ReadWrite.GetListOfUsers())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            // Det första som skall ske är en deserialize för att kolla om filerna finns.
            // Sen kör vi get list of users, om dess count är 0. Skapa en ny admin som skickas in 
            // i serialize samt två st dummy users.  
            // Sen kör vi deserialize igen för att spara in admin i listan.
            // lägg detta i en do while loop som kontrollerar om getList of users är större än 0
            // är den det så avsluta loopen och gå till inloggnings GUI.
            // 

            Login.Start();
        }
    }
}
