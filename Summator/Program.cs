// See https://aka.ms/new-console-template for more information
using System;

namespace Summator
{
    public class Program
    {
        static void Main (string[] args)
        {
            long result = Summator.Sum(new long[] { 1, 2, 3, 4, 5, 6 });

            if (result == 20)
            {
                Console.WriteLine("TEST PASS");
            }
            else
            {
                Console.WriteLine("TEST FAIL");
            }

        }
    }
}


