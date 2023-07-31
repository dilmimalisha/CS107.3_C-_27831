using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07.Q8
{
    class Animal
    {
        public void Display()
        {
            Console.WriteLine("I am an Animal.");
        }
    }

    class Dog : Animal
    {
        public void DisplayDogInfo()
        {
            Console.WriteLine("I have four legs.");
        }
    }

    class Program
    {
        static void Main()
        {
            Dog dog = new Dog();
            dog.Display();
            dog.DisplayDogInfo();
        }
    }
}
