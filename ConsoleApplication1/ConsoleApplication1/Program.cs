using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет");
            String name = Console.ReadLine();
            if (name == "Саша")
            {
                Console.WriteLine("Привет " + name);
            } else
            {
                string other = name;
                Console.WriteLine("Привет " + other);
            }
            Console.ReadLine();

        }
    }
}
