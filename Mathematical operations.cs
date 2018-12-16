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

            Console.WriteLine("Enter random number and we will multiplay by 50");
            string num1 = Console.ReadLine();
            int total;
            total = int.Parse(num1) * 50;
            Console.WriteLine(total);

            Console.WriteLine("Enter random number and we will add 25 and show results");
            string num2 = Console.ReadLine();
            int total1;
            total1 = int.Parse(num2) + 25;
            Console.WriteLine(total1);

            Console.WriteLine("Enter random number and we will divides it by 12.5 show results");
            string num3 = Console.ReadLine();
          float.Parse(num3);
            float num77 = 12.5f;
           float total77 = float.Parse(num3) / num77;

            Console.WriteLine(total77);

            Console.WriteLine("Enter random number and we will will check if is greater than a number");
            string num4 = Console.ReadLine();
            int.Parse(num4);
            bool num5;
             num5= int.Parse (num4) <= 50;
            Console.WriteLine(num5);

            Console.WriteLine("Enter random number and we will divide it by 7 and give you the reminder");
            string num6 = Console.ReadLine();
            int num7 = 7;
            int total8 = int.Parse(num6) % num7 ;
            Console.WriteLine(total8);
            

        }
    }
}
