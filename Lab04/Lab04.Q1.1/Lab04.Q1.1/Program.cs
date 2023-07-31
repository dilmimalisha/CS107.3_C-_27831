using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04.Q1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertValues converter = new ConvertValues();
            converter.kilometerTOmeter();

            Console.ReadLine();
        }
    }

    class ConvertValues
    {
        public void kilometerTOmeter()
        {
            Console.Write("Enter the distance in kilometers: ");
            double km = double.Parse(Console.ReadLine());

            double m = km * 1000;
            Console.WriteLine($"{km} kilometers is equal to {m} meters.");
        }
    }
}

