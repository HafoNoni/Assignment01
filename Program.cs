using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            double b = 4.0;
            string c = "polyilaro";

            Console.WriteLine("Enter Second Number:");
            int second_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Value:");
            double second_value = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second String Value:  ");
            string second_string = Console.ReadLine();

            Console.WriteLine(a + second_num);
            Console.WriteLine(b + second_value);
            Console.WriteLine(c + " " + second_string);

            Console.ReadLine();
        }
    }
}
