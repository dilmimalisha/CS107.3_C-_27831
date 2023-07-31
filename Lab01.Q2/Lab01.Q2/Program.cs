using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the radius:");
            double radius = double.Parse(Console.ReadLine());

            double pi = 3.142;
            double area;

            area = pi*radius*radius;
            Console.WriteLine("Area of the circle:" +  area);

            Console.ReadLine();

        }
    }
}
