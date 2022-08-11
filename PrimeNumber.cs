using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public static class PrimeNumber
    {
        public static void DisplayPrimeNumber()
        {
            int n, i, m = 0, flag = 0;


            Console.WriteLine("Find the PrimeNumber within given number");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i < m; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Number is not Prime");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Number is Prime");
            }
        }
    }
}

