using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTeller
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Awaiting user input. Please enter 3 comma-seperated interger values representing angles (a, b, c).");

            string input = Console.ReadLine();

            Console.WriteLine(input);

            foreach (string next in args)
            {
                Console.WriteLine(next);
                
            }
            
            Console.ReadKey();

        }
    }
}
