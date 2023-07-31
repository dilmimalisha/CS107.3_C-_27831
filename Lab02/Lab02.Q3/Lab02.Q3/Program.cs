using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the radius:");
            double radius = double.Parse(Console.ReadLine());

            double pi = 3.142;
           
            double area = pi * radius * radius;
            double circum = 2 * pi * radius;

            Console.WriteLine("Area of the circle:" + area);
            Console.WriteLine("Circumference of the circle:" + circum);

            Console.ReadLine();


        }
    }
}
