using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfPrimes
{
    class Program
    {
        static bool CheckPrime(int primeCheck)
        {
            if (primeCheck == 2)
            {
                return true;
            }
            if (primeCheck == 0 || primeCheck == 1)
            {
                return false;
            }

            for (int i = 2; i < primeCheck; i++)
            {
                
                
                if (primeCheck % i == 0)
                {
                    return false;
                }
                else if (i == primeCheck-1)
                {
                    return true;
                }
                else
                {

                }
                
                
            }
            return false;
        }
        static void Main(string[] args)
        {
            int final = 0;
            bool result = false;
            int counter = 0;
            for (int i = 0;; i++)
            {
                result = CheckPrime(i);
                if (result == false)
                {

                }
                else
                {
                    final += i;
                    counter++;
                }
                
                if (counter == 1000)
                {
                    break;
                }
            }
            Console.WriteLine(final);
        }
    }
}

