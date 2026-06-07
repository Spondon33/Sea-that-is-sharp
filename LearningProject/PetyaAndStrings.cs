using System;
using System.Globalization;

namespace cmp
{
    class PetyaAndStrings
    {
        static void Main(string[] args)
        {
            string str1  = Console.ReadLine().ToLower();
            string str2  = Console.ReadLine().ToLower();

            int strComp = string.Compare(str1, str2, ignoreCase: true);
            Console.WriteLine(strComp);
        }
    }
};

