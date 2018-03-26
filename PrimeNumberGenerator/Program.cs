using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {




                bool isPrime = true;
                Console.WriteLine("Prime Numbers : ");
                for (int i = 3; i > 0; i++)
                {
                    for (int j = 3; j <= 800000; j++)
                    {

                        if (i != j && i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }

                    }
                    if (isPrime)
                    {
                        Console.WriteLine("\t" + i);
                    }
                    isPrime = true;
                }








                Console.ReadKey();
            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
