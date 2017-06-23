using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class EmployeePortal
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public void Run()
        {
            string choice = UserUI.GetStringInput("What would you like to do? \n Add Animal to database: '1' \n Match Adopter Bio to an animal: '2' \n Update Animal Bio: '3' \n To go back: 'back' \n Exit the porgram: 'exit'"
);
            PickTheTask(choice);
        }
        public void PickTheTask(string choice)
        {
            switch (choice)
            {
                case "1":
                    AddAnimal();
                    break;
                case "2":
                    SearchBio();
                    break;
                case "3":
                    UpdateAnimalBio();
                    break;
                case "back":
                    MainMenu.Run();
                    break;
                default:
                    UserUI.DisplayMessage("Oops! You entered a wrong message! try again.");
                    Console.ReadLine();
                    Console.Clear();
                    Run();
                    break;
            }
        }
        public void AddAnimal()
        {

        }
        public void SearchBio()
        {

        }
        public void UpdateAnimalBio()
        {

        }
    }
}
