using System.Globalization;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = 1000 / 12.34;
            Console.WriteLine(value);
            Console.WriteLine($"{value:0}");
            Console.WriteLine($"{value:0.0}");
            Console.WriteLine($"{value:0.00}");
            Console.WriteLine($"{value:0.#}");

            double money = -10d / 3d;
            Console.WriteLine(money);
            Console.WriteLine($"{money:C}");
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