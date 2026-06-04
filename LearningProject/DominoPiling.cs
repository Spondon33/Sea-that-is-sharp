using System;
using System.Globalization;

namespace cmp
{
    class DominoPiling
    {
        static void Main(string[] args)
        {
            string Line = Console.ReadLine();
            string[] parts = Line.Split(' ');
            
            int m = int.Parse(parts[0]);
            int n = int.Parse(parts[1]);

            Console.WriteLine((int)Math.Floor((m * n) / 2.0));
        }
    }
}