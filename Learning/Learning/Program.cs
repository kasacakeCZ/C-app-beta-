using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("- - - - - - %%%%%%%%%%% - - - - - - %%%%%%%%%%% - - - - - ");
            Console.WriteLine("- - - - - - - - - %%%%%%% - - - - %%%%%%% - - - - - - - - ");
            Console.WriteLine("- - - - - - - - - - -  %%%% - - %%%% - - - - - - - - - - -");
            Console.WriteLine("- - - - - - WELCOME IN DEMIGOD´S SIMPLE C# CONSOLE - - - -");
            Console.WriteLine("- - - - - - - - - - - - APPLICATION  - - - - - - - - - - - ");
            Console.WriteLine("- - - - - - - - - - -  %%%% - - %%%% - - - - - - - - - - -");
            Console.WriteLine("- - - - - - - - - %%%%%%% - - - - %%%%%%% - - - - - - - - ");
            Console.WriteLine("- - - - - - %%%%%%%%%%% - - - - - - %%%%%%%%%%% - - - - - ");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Zadej číslo pro napočítání a prohození sudých/lichých čísel: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("_____");


            for (int i = 2; i < start - 4;)
            { 
                if (i == 2)
                Console.WriteLine(i); // 2...


                if (i % 2 == 0)
                {
                    --i;
                    Console.WriteLine(i); // 1...
                    Console.WriteLine("_____");
                }

                i += 3;
                Console.WriteLine(i); // 4...
                --i;
                Console.WriteLine(i); // 3...

                Console.WriteLine("_____");

                if (i % 2 != 0)
                {
                    i += 3; 
                    Console.WriteLine(i); // 6...
                    --i;
                    Console.WriteLine(i); // 5...
                    Console.WriteLine("_____");

                }


            }

            
            Console.ReadKey();
        }
    }
}
