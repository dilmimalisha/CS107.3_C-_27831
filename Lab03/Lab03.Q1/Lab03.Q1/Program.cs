﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());


            if (number % 2 == 0)
            {
                Console.WriteLine("Even.");
            }
            else
            {
                Console.WriteLine("Odd.");
            }
            Console.ReadLine();

        }
    }
}
