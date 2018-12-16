using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_and_comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program.");
            Console.WriteLine(" Enter Employee 1 Houlry rate");
            String p1hrate = Console.ReadLine();
            float.Parse(p1hrate);

            Console.WriteLine(" Enter Employee 1 Hours worked per week");
            String p1hweek = Console.ReadLine();
            float.Parse(p1hweek);


            Console.WriteLine(" Enter Employee 2 Houlry rate");
            String p2hrate = Console.ReadLine();
            float.Parse(p2hrate);

            Console.WriteLine(" Enter Employee 2 Hours worked per week");
            String p2hweek = Console.ReadLine();
            float.Parse(p2hweek);

            float totalp1 = float.Parse(p1hrate) * float.Parse(p1hweek);
            Console.WriteLine("Weekly salary of Employee 1 = " + totalp1);

            float totalp2 = float.Parse(p2hrate) * float.Parse(p2hweek);
            Console.WriteLine("Weekly salary of Employee 2 = " + totalp2);

            Console.WriteLine("Does Employee 1 make more money than Person 2?");
            bool increase1;
            increase1 = totalp1 > totalp2;
            Console.WriteLine(increase1);
        }
    }
}

