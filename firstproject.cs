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
            string textage = "25";
            int age = Convert.ToInt32(textage);
            Console.WriteLine(age);
            
            String textpopulation = "7800000000";
            long population = Convert.ToInt64(textpopulation);
            Console.WriteLine(population);
            
            String textprice = "19.99";
            double price = Convert.ToDouble(textprice);
            Console.WriteLine(price);
            
            String texttemperature = "36.5";
            float temperature = Convert.ToSingle(texttemperature);
            Console.WriteLine(temperature);
            
            String textsalary = "50000.00";
            decimal salary = Convert.ToDecimal(textsalary);
            Console.WriteLine(salary);
        }
    }
}