using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfPrimes
{
    class Program
    {
        static int CheckPrime(int primeCheck)
        {
            int s = 7;
            for (int i = 2; i < primeCheck; i++)
            {
                
                if (primeCheck == 2)
                {
                     s=1;
                }
                else if (primeCheck == 0 || primeCheck == 1)
                {
                    s=2;
                }
                else if (primeCheck % i == 0)
                {
                    s=3;
                }
                else
                {
                    s=4;
                }
                
                
            }
            return s;
        }
        static void Main(string[] args)
        {
            int final = 2;
            int result = CheckPrime(final);
            //int counter = 0;
            //for (int i = 0; i<5 ; i++)
            //{
            //    result = CheckPrime(i);
            //    if (result == 0)
            //    {
            //        //final += i;
            //        //counter++;
            //    }
            //    else if (result==1)
            //    {
            //        final += i;
            //        counter++;
            //        //Console.WriteLine(final);
            //    }
            //    else
            //    {

            //    }
            //    if (counter == 1000)
            //    {
            //        break;
            //    }
            //}
            Console.WriteLine(result);
        }
    }
}

