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
            StatOrEndProgram();

        }
        private static void StatOrEndProgram()
        {
            Console.WriteLine("Welcome to the Humane Society Pet Adoption Database. To get started, type 'start' or to close out, type 'exit'");
            string initialInput = Console.ReadLine();
            switch (initialInput)
            {
                case "start":
                    Console.Clear();
                    SelectUserType();
                    break;
                case "exit":
                    break;
                default:
                    Console.WriteLine("Oops! You entered a wrong message! try again.");
                    Console.ReadLine();
                    Console.Clear();
                    StatOrEndProgram();
                    break;
            }
        }
        private static void SelectUserType()
        {
            Console.WriteLine("Are you an adoptee here to adopt an anaimal or Are you an employee? Type 'adoptee' or 'employee' or, to close out, type 'exit'");
            string userTypeInput = Console.ReadLine();
            switch (userTypeInput)
            {
                case "adoptee":
                    Console.Clear();
                    AdopterUI.Run();
                    break;
                case "employee":
                    Console.Clear();
                    EmployeeUI.Run();
                    break;
                case "exit":
                    break;
                default:
                    Console.WriteLine("Oops! You entered a wrong message! try again.");
                    Console.ReadLine();
                    Console.Clear();
                    StatOrEndProgram();
                    break;
            }

        }
    }
}

