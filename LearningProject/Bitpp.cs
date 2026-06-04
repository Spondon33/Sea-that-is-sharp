using System;
using System.Globalization;

namespace cmp
{
    class Bitpp
    {
        static void Main(string[] args)
        {
            int numOfInput = Convert.ToInt32(Console.ReadLine());
            int x = 0;

            for (int i = 0; i < numOfInput; i++)
            {
                string userinput = Console.ReadLine();
                if (userinput.Contains("++"))
                {
                    x += 1;
                }
                else
                {
                    x -= 1;
                }
            }
            Console.WriteLine(x);
        }
    }
}