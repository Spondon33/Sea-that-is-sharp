using System;
using System.Globalization;

namespace Program0
{
    class Program
    {
        static void Main(string[] args)
        {
            bool success = true;
            while (success)
            {
                Console.Write("Enter a number: ");
                String input = Console.ReadLine();
                
                if (int.TryParse(input, out int num))
                {
                    success = false;
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("Failed to parse input.");
                }
            }
        }
    }
}