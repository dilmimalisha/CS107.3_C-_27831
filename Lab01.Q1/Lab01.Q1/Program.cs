using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            

            Console.Write("Enter your batch: ");
            double batch = double.Parse(Console.ReadLine());


            Console.WriteLine("My name is " + name);
            Console.WriteLine("Batch " +  batch);

            Console.ReadLine();

        }
    }
}
