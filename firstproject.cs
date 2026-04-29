using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace firstproject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.ReadLine(); ---> to take input from user
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name + "!" + " You are " + age + " years old.");
            if (age < 10 && age > 0)
            {
                Console.WriteLine("How can u even code ? :) ");
            }
            else if (age >= 10 && age < 18)
            {
                Console.WriteLine("You're still a kid XD");
            }
            else if (age >= 18 && age < 60)
            {
                Console.WriteLine("Respect to you big bro");
            }
            else if (age >= 60)
            {
                Console.WriteLine("y r u coding?? go spend time with your family. u might die soon :D ");
            }
            else
            {
                Console.WriteLine("Invalid age entered.");
            }
        }
    }
}