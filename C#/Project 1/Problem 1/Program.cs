using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            for (var i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine("Sum of all multiples of 3 or 5 below 1000: " + Convert.ToString(sum));
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
