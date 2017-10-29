using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyNumberLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a number to multiply by numbers 1 through 10.");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 11; i++)
                Console.WriteLine("{0} x {1} = {2}", n, i, (n * i));
            Console.ReadLine();
        }
    }
}
