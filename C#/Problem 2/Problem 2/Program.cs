using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lastValues = { 1, 2 };
            int sum = 2;
            while (lastValues[1] < 4000000)
            {
                int tmp = lastValues.Sum();
                lastValues[0] = lastValues[1];
                lastValues[1] = tmp;
                if (tmp % 2 == 0)
                {
                    sum += tmp;
                }
            }

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
