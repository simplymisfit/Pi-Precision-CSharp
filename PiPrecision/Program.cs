using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiPrecision
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("X:");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x < 0)
            {
                Console.WriteLine("Number is too low!");
            }
            else if (x >= 16)
            {
                Console.WriteLine("Number is too big!");
            }
            else if (x > 0 && x < 16)
            {
                Console.WriteLine("Given number is");
                Console.WriteLine(Math.Round(Math.PI, x));

            }
            else
            {
                Console.WriteLine("That's not a number!");
            }
        }
    }
}
