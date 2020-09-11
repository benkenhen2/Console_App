using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What should I say: ");
            String userInput = Console.ReadLine();
            Console.WriteLine("Console: " + userInput);
        }
    }
}
