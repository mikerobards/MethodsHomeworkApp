using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsHomework
{
    internal class ConsoleMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Methods Homework App!");
            Console.WriteLine("Written by Mike Robards 2022");
            Console.WriteLine();
        }

        public static string AskUsersName()
        {
            Console.Write("What is your name: ");
            string output = Console.ReadLine();
            return output;
        }

        public static void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }
    }
}
