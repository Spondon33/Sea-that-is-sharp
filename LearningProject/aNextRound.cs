using System;
using System.Globalization;

namespace cmp
{
    class aNextRound
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            int n = int.Parse(parts[0]);
            int k = int.Parse(parts[1]);
            
            int[] scores = new int[n];
            
            string[] scoreparts = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                scores[i] = int.Parse(scoreparts[i]);
            }
            
            int count = 0;
            for (int j = 0; j < n; j++)
            {
                if (scores[j] >= scores[k - 1] && scores[j] > 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}