using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06.Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the arrays:");
            int size = int.Parse(Console.ReadLine());

            int[] array1 = new int[size];
            int[] array2 = new int[size];

            Console.WriteLine("Enter values for the first array:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter value {i + 1}:");
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter values for the second array:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter value {i + 1}:");
                array2[i] = int.Parse(Console.ReadLine());
            }

            // Scalar Sum
            int scalarSum = 0;
            for (int i = 0; i < size; i++)
            {
                scalarSum += array1[i] + array2[i];
            }

            Console.WriteLine("Scalar Sum:");
            Console.WriteLine(scalarSum);

            // Vector Sum
            int[] vectorSum = new int[size];
            for (int i = 0; i < size; i++)
            {
                vectorSum[i] = array1[i] + array2[i];
            }

            Console.WriteLine("Vector Sum:");
            PrintArray(vectorSum);

            // Vector Product
            int[] vectorProduct = new int[size];
            for (int i = 0; i < size; i++)
            {
                vectorProduct[i] = array1[i] * array2[i];
            }

            Console.WriteLine("Vector Product:");
            PrintArray(vectorProduct);

            // Scalar Product
            int scalarProduct = 0;
            for (int i = 0; i < size; i++)
            {
                scalarProduct += array1[i] * array2[i];
            }

            Console.WriteLine("Scalar Product:");
            Console.WriteLine(scalarProduct);
        }

        static void PrintArray(int[] arr)
        {
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}
