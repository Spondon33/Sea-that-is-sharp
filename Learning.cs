using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            int age = -10;
            // condition ? true result : false result
            string result = age > 0 ? "Age is valid" : "Age is invalid";
            Console.WriteLine(result);
        }
    }
}