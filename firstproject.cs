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
            // const Keyword

            const int vat = 20; // constant variable, cannot be changed after initialization
            const double percentVat = vat / 100d;
            int balance = 1000;

            Console.WriteLine(balance * (vat / 100d));
            Console.WriteLine(balance * percentVat);

        }
    }
}