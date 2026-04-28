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
            // ++, --, +=, -=, *=, /=
            int age = 25;
            age++;
            Console.WriteLine(age);
            age--;
            Console.WriteLine(age);
            age *= 10;
            Console.WriteLine(age);
            age /= 10;
            Console.WriteLine(age);
            double pr = 26;
            pr /= 5;
            Console.WriteLine(pr);

            string name = "John";
            name += " is programming";
            // name -=" is programming"; ---> NOT POSSIBLE 
            Console.WriteLine(name);

            char ch = 'a';
            ch += 'b'; // this will add the ASCII values of 'a' and 'b' and assign it to ch
            Console.WriteLine(ch);

            int i = 0;
            i++;
            Console.WriteLine(i);

            int j = 0;
            Console.WriteLine(j++);
            Console.WriteLine(j);

            int firstnum = 10;
            int secondnum = 3;
            Console.WriteLine(firstnum / secondnum);
            Console.WriteLine(firstnum % secondnum); // this will give the remainder of the division of firstnum by secondnum

            
        }
    }
}