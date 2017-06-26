using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public static class UserUI
    {
        public static string GetStringInput(string ConsoleMessage)
        {
            DisplayMessage(ConsoleMessage);
            string input = Console.ReadLine();
            return input;
        }
        public static int GetIntInput(string ConsoleMessage)
        {
            DisplayMessage(ConsoleMessage);
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
        public static decimal GetDecimalInput(string ConsoleMessage)
        {
            DisplayMessage(ConsoleMessage);
            decimal input = Convert.ToDecimal(Console.ReadLine());
            return input;
        }
        public static void DisplayMessage(string Message)
        {
            Console.WriteLine(Message);
        }
    }
}
