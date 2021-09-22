/******************************************************************
* Program(1).cs
* Computes floor(lg lg (n))
* CS 212A
* Brea Koenes, 09/16/21
******************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lg(Lg(n)) Finder");
            while (true)
            {
                // prompt user for N
                Console.Write("\nEnter N: ");
                double n = double.Parse(Console.ReadLine());
                double lg = (Lg(n));
                double lglg = (Lg(Lg(n)));

                // writes a message to the console if lg<1
                if (lg < 1)
                    Console.WriteLine("Undefined result, enter a valid number");
                // otherwise write the answer to the console 
                else
                    Console.WriteLine("lg(lg({0})) = {1}.", n, lglg);
            }
        }
        static double Lg(double n)
        {
           double result = 0;
            // do not compute log(log(N)) if N<=0
            if (n <= 0)
                return -1;
            else
                // compute log(log(N)) if N>1
                while (n > 1)
                {
                    n = n / 2;
                    result = result + 1;
                }
            return result;
        }
    }
}
