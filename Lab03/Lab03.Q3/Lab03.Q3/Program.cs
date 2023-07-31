using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;


            for (int tN = number; tN != 0; tN /= 10) //tN=tempNumber
            {
                
                int digit = tN % 10;

                
                sum += digit; // Add the digit to the sum

             
            }

            Console.WriteLine("The sum of the digits is: " + sum);
            Console.ReadLine();
        }
    }
}
