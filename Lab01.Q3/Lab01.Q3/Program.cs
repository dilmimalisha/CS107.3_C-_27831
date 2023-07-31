using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int value1;
            Console.Write("Enter first value:");
            value1 = int.Parse(Console.ReadLine());

            int value2;
            Console.Write("Enter second value:");
            value2 = int.Parse(Console.ReadLine());

            int sum = value1 + value2;
            Console.WriteLine("Sum of the entered two values:" + sum);

            Console.ReadLine();
        }
    }
}
