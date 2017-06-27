using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public static class MainMenu
    {
        public static void Run()
        {
            try
            {
                string choice = UserUI.GetStringInput("Welcome to the Humane Society Pet Adoption Database. To get started, type 'start' or to close out, type 'exit'");
                StatOrEndProgram(choice);
            }
            catch
            {
                UserUI.DisplayMessage("Oops! You entered a wrong message! try again.");
                Console.ReadLine();
                Console.Clear();
               Run();
            }
        }
        private static void StatOrEndProgram(string choice)
        {
            switch (choice)
            {
                case "start":
                    Console.Clear();
                    SelectUserType(UserUI.GetStringInput("Are you an adopter here to adopt an anaimal or Are you an employee? Type 'adopter' or 'employee' or, to close out, type 'exit'"));
                    break;
                case "exit":
                    break;
                default:
                    UserUI.DisplayMessage("Oops! You entered a wrong message! try again.");
                    Console.ReadLine();
                    Console.Clear();
                    Run();
                    break;
            }
        }
        private static void SelectUserType(string choice)
        {
            switch (choice)
            {
                case "adopter":
                    Adopter adopter = new Adopter();
                    Console.Clear();
                    adopter.Run();
                    break;
                case "employee":
                    EmployeePortal employeePortal = new EmployeePortal();
                    Console.Clear();
                    employeePortal.Run();
                    break;
                case "exit":
                    break;
                default:
                    UserUI.DisplayMessage("Oops! You entered a wrong message! try again.");
                    Console.ReadLine();
                    Console.Clear();
                    Run();
                    break;
            }

        }
    }
}

