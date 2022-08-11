using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public static class StopWatch
    {

        public static void DisplayStopWatch()
        {

            int start, end;

            Console.WriteLine("Find the Elapsed Time ");

            Console.WriteLine("Input the starting number ");
            start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the ending number ");
            end = Convert.ToInt32(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                Thread.Sleep(1);
            }

            Console.WriteLine(" Time Elapsed : {0}");
            



        }
    }
}
