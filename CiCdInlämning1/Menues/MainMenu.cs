using CiCdInlämning1.Interfaces;
using CiCdInlämning1.Utilities;
using System;
using System.Collections.Generic;

namespace CiCdInlämning1.Menues
{
    class MainMenu
    {
        private List<string> MenuOptions = new() { "Lön", "Anställning", "Ta bort användare", "Logga ut", "Avsluta programmet" };
        ISaveable User;

        public MainMenu(ISaveable user)
        {
            User = user;
        }

        public void Start()
        {
            bool exit = false;
            do
            {
                Console.Clear();
                Console.Write($"Inloggad som: {User.Name} ");
                if (User.IsAdmin)
                {
                    PrintFormating.PrintTextInGreen("(Admin)");
                }
                else
                {
                    Console.WriteLine("\n");
                }
                for (int i = 0; i < MenuOptions.Count; i++)
                {
                    if (User.IsAdmin && MenuOptions[i].Contains("Ta bort användare"))
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"{i + 1}. {MenuOptions[i]}");
                    }
                }

                Console.WriteLine("\n");

                if (User.IsAdmin)
                {

                }

                Console.Write("Gör ditt val > ");
                var choiceIsNumber = int.TryParse(Console.ReadLine(), out int menuChoice);
                if (choiceIsNumber)
                {
                    switch (menuChoice)
                    {
                        case 4:
                            exit = true;
                            break;
                        case 5:
                            Environment.Exit(1);
                            break;
                        default:
                            break;
                    }
                }

            } while (!exit);

        }
    }
}
