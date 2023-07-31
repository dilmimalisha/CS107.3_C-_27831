using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter number 1:");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number 2:");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            int subtraction = num1 - num2;
            int multiplication = num1 * num2;
            float division = num1 /(float) num2;

            Console.WriteLine("The sum of the two numbers:" + sum);
            Console.WriteLine("The subtraction of the two numbers:" + subtraction);
            Console.WriteLine("The multiplication of the two numbers:" + multiplication);
            Console.WriteLine("The division of the two numbers:" + division);

            Console.ReadLine();

        }
    }
}
