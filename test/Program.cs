//Cesario Kufner
//Learning C#

using System;

namespace test
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("----------");
            Console.WriteLine("");
            Console.WriteLine("Choose operation:");
            Console.WriteLine("1: +");
            Console.WriteLine("2: -");
            Console.WriteLine("3: *");
            Console.WriteLine("4: /");
            Console.WriteLine("");
            Console.WriteLine("");

            string operation = Console.ReadLine();

            if(operation == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("You chose +");
                Console.WriteLine("--------------");
                Console.WriteLine("Enter number:");
                string inp1 = Console.ReadLine();
                Console.WriteLine("+");
                string inp2 = Console.ReadLine();

                int x = int.Parse(inp1);
                int y = int.Parse(inp2);

                Console.WriteLine("=");
                Console.WriteLine(x+y);
            }

            if(operation == "2")
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("You chose +");
                Console.WriteLine("--------------");
                Console.WriteLine("Enter number:");
                string inp1 = Console.ReadLine();
                Console.WriteLine("-");
                string inp2 = Console.ReadLine();

                int x = int.Parse(inp1);
                int y = int.Parse(inp2);

                Console.WriteLine("=");
                Console.WriteLine(x-y);
            }

            if(operation == "3")
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("You chose +");
                Console.WriteLine("--------------");
                Console.WriteLine("Enter number:");
                string inp1 = Console.ReadLine();
                Console.WriteLine("*");
                string inp2 = Console.ReadLine();

                int x = int.Parse(inp1);
                int y = int.Parse(inp2);

                Console.WriteLine("=");
                Console.WriteLine(x*y);
            }

            if(operation == "4")
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("You chose +");
                Console.WriteLine("--------------");
                Console.WriteLine("Enter number:");
                string inp1 = Console.ReadLine();
                Console.WriteLine("/");
                string inp2 = Console.ReadLine();

                int x = int.Parse(inp1);
                int y = int.Parse(inp2);

                Console.WriteLine("=");
                Console.WriteLine(x/y);
            }
        }
    }
}