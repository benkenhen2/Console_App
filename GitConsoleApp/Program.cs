/*  Program: GitConsoleApp.cs
 *  
 *  Description: First time using Visual Studio
 *  
 *  Revision History:
 *      created Sept 11, 2020 by B. Hengeveld
 */

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
