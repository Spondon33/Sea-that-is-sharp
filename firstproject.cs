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
            int age = 25;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long population = 7800000000;
            Console.WriteLine(population);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double price = 19.99;
            Console.WriteLine(price);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float temperature = 36.5f;
            Console.WriteLine(temperature);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            decimal salary = 50000.00M;
            Console.WriteLine(salary);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            // Console.ReadLine();
        }
    }
}