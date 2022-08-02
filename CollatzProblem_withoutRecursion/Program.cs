using System;
using System.Collections.Generic;


namespace CollatzProblem_withoutRecursion
{

    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(" Please enter the number s: ");
            int s = int.Parse(Console.ReadLine());
            int n = 0;
            while (s != 1)
            {
                if ( s % 2  == 0)
                    s = s/2;
                else
                    s = 3 * s + 1  ;
                n++;
            }
            
            Console.WriteLine($"The number of steps:  {n}\n\n");


            Console.ReadKey();
        }
    }
}