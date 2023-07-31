using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06.Q6
{
    class CalculateValues
    {
        public int[] UserInput(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine());
                array[i] = number;
            }

            return array;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size:");
            int size = int.Parse(Console.ReadLine());

            CalculateValues calculateValues = new CalculateValues();

            int[] array = calculateValues.UserInput(size);

            Console.WriteLine("The array elements are:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }

}
