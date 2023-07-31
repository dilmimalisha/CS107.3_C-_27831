using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int[] numInputs = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter {i + 1} number:");
                int num = int.Parse(Console.ReadLine());
                numInputs[i] = num; // Store the user input in the array
            }

            for (int i = 0; i < 10; i++)
            {
                
                if (numInputs[i] % 2 == 0) 
                {
                    Console.WriteLine("The number {0} is even.", numInputs[i]);
                }
                else
                {
                    Console.WriteLine("The number {0} is odd.", numInputs[i]);
                }
                
                
            }
            Console.ReadLine();

        }
    }
}
