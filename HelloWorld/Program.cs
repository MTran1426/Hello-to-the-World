/*HelloWorld Program
 * (c) Melvin Tran
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; // I want direct acess to the static members of the Console class

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args != null && args.Length > 0) // I have one or more strings supplied to my program
            {
                foreach (string word in args)
                {
                    WriteLine($"Hello {word}");
                }
            }
            else
            {
                //Help Information
                ForegroundColor = ConsoleColor.Green; // Change the forground color
                WriteLine(@"Hello World
======== =======

Usage: .\HelloWorld [names]

where
     [names] is a Space-separated list of names");
                ResetColor(); //Resets the color
            }
        }
    }
}
