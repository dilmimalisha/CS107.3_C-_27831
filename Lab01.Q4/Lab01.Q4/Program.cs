using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your salary:");
            double salary = double.Parse(Console.ReadLine());
            
            
            Console.Write("Enter the precentage of tax rate:");
            double taxRate = double.Parse(Console.ReadLine());

            double tax =salary*( taxRate / 100);
            Console.WriteLine("Calculated tax:" + tax);

            double grossSalary = salary- tax;
            Console.WriteLine("The salary after  the tax:" +  grossSalary);

       
            Console.ReadLine();


            

        }
    }
}
