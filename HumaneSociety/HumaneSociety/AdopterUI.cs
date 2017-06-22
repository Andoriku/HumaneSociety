using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public static class AdopterUI
    {
        public static void Run()
        {

        }
        private static string GetInput()
        {
            string input = Console.ReadLine();
            return input;
        }
        private static void PickTheTask()
        {
            Console.WriteLine("what would you like to do? \n Enter a bio: '1' \n Search for an animal: '2' \n Browse all animals: '3' \n To go back: 'back' \n Exit the porgram: 'exit'");
            string choice = GetInput();
            switch (choice)
            {
                case "1":
                    EnterBio();
                    break;
                case "2":
                    SearchFor();
                    break;
                case "3":
                    BrowseAnimals();
                    break;
                case "back":
                    MainMenu.Run();
                    break;
                case "exit":
                    break;
                default:
                    Console.WriteLine("Oops! You entered a wrong message! try again.");
                    Console.ReadLine();
                    Console.Clear();
                    PickTheTask();
                    break;
            }

        }
    }
}
