using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Console.Write("Enter your first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int solution = num1 * num2;
            int answer = 0;

            Console.WriteLine("What is " + num1 + " x " + num2 + " ?");
            
            while (answer != solution)
            {
                Console.Write("Ans: ");
                answer = Convert.ToInt32(Console.ReadLine());

                if (answer != solution)
                {
                    Console.WriteLine("Wrong Answer! Try Again.");
                }
            }

            Console.WriteLine("Your Answer is Correct! Well Done!");
        }
    }
}