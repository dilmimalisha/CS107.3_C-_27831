using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a positive integer:");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine("The sum of all odd numbers from 1 to " + num + " is: " + sum);
            Console.ReadLine();

        }
    }
}
