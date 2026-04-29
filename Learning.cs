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
            Console.WriteLine("How many times do you want to repeat your message?");
            Console.Write("Ans: ");
            int counter = Convert.ToInt32(Console.ReadLine());

            if (counter <= 0)
            {
                Console.WriteLine("Invalid Number! PLs try again.");
            }
            else
            {
                Console.Write("Enter your message: ");
                string message = Console.ReadLine();

                for (int i = 0; i < counter; i++)
                {
                    Console.WriteLine(message);
                }
            }
        }
    }
}