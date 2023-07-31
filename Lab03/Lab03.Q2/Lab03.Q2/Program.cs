using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string vowels = "aeiouAEIOU";
            string text;
            Console.WriteLine("Enter a string:");
            text = Console.ReadLine();
            

            int vowelCount = 0;

            for(int i=0; i< text.Length; i++)
            {
                char ch = text[i];
                if(vowels.Contains(ch))
                {
                    vowelCount++;
                }
            }
            Console.WriteLine($"Number of vowels in the string: {vowelCount}");

            Console.ReadLine();



        }
    }
}
