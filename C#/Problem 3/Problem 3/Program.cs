using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong number = 600851475143;
            ulong factor = 0;
            for(ulong i = 1; i < number; i++)
            {
                if (i <= 0)
                    break;
                if (number % i == 0)
                {
                    Console.WriteLine("F: " + i);
                    // It is a factor, is it prime?
                    if (isPrime(i))
                    {
                        // It is prime
                        if (i >= factor)
                        {
                            Console.WriteLine("P: " + i);
                            factor = i;
                        }
                    }
                }
            }

            Console.WriteLine("Solution: " + factor);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }

        static bool isPrime(ulong number)
        {

            for (ulong i = 2; i*i <= number; i++)
            {
                if (number % i == 0 && i != number)
                    return false;
            }
            
            return true;
        }
    }
}
