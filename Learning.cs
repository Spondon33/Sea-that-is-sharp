using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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
            double value = 1000 / 12.34;
            Console.WriteLine(value);
            Console.WriteLine(String.Format("{0:0}", value));
            Console.WriteLine(String.Format("{0:0.0}", value));
            Console.WriteLine(String.Format("{0:0.00}", value));
            Console.WriteLine(String.Format("{0:0.#}", value));

            double money = -10d / 3d;
            Console.WriteLine(money);
            Console.WriteLine(String.Format("${0:0.00}", money));
            Console.WriteLine(money.ToString("C"));
            Console.WriteLine(money.ToString("C0"));
            Console.WriteLine(money.ToString("C1"));
            Console.WriteLine(money.ToString("C2"));

            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));

        }
    }
}