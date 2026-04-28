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
            //with the var keyword, the compiler can detect the data type from the assigned value.

            // int age = 20;
            var age = 20; 
            Console.WriteLine(age);

            // long population = 7800000000;
            var population = 7800000000;
            Console.WriteLine(population);

            // double negative = -3.14;
            var negative = -3.14;
            Console.WriteLine(negative);

            // float precision = 3.141592654f;
            var precision = 3.141592654f;
            Console.WriteLine(precision);

            // decimal money = 100.50m;
            var money = 100.50m;
            Console.WriteLine(money);

            // string name = "John";
            var name = "John";
            Console.WriteLine(name);

            // char grade = 'A';
            var grade = 'A';
            Console.WriteLine(grade);

            //bool isStudent = true;
            var isStudent = true;
            Console.WriteLine(isStudent);
        }
    }
}