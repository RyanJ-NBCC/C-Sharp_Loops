using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            bool condition = false;
            string[] listItems = { "ListItem1", "ListItem2", "ListItem3" };

            //While loops
            Console.WriteLine("\nwhile loops:");
            while (condition)
            {
                Console.WriteLine("I run only while condition is true.");
            }

            //Do while loops
            Console.WriteLine("\nDo while loops:");
            do
            {
                Console.WriteLine("I always run once whether condition is true or not.");
            } while (condition);

            //For loops
            Console.WriteLine("\nFor loops:");
            for (int iteration = 0; iteration < 3; iteration++)
            {
                Console.WriteLine("Define iteration veriable, Condition, adjust iteration variable");
            }

            //Foreach loops
            Console.WriteLine ("\nForeach loops will loops over the items in a list: ");
            foreach (var item in listItems)
            {
                Console.WriteLine($"{item}");
            }
            
            Console.ReadLine();
        }
    }
}
