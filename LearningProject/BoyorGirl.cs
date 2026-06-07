using System;
using System.Globalization;

namespace cmp
{
    class BoyorGirl
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            char[] usernameArray = username.ToCharArray();
            HashSet<char> distinctArray = new HashSet<char>();
            
            for (int i = 0; i < username.Length; i++)
            {
                distinctArray.Add(usernameArray[i]);
            }
            
            int count = distinctArray.Count;

            if (count % 2 == 0)
            {
                Console.WriteLine("CHAT WITH HER!");
            }
            else
            {
                Console.WriteLine("IGNORE HIM!");
            }
        }
    }
};

