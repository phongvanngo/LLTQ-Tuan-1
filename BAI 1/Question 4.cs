using System;
using System.Collections.Generic;
using System.Text;
using MY_UTILITIES;

namespace DAY_1
{
    partial class Program
    {
        public static void Question_4()
        {
            Console.WriteLine("\nCau 4");
            Console.Write("A.tu: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("A.mau: ");
            int b = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("B.tu: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("B.mau: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Fraction A = new Fraction(a, b);
            Fraction B = new Fraction(c, d);

            Console.WriteLine((string)A + " + " + (string)B + " = "+(string)(A+B));
            Console.WriteLine((string)A + " - " + (string)B + " = "+(string)(A-B));
            Console.WriteLine((string)A + " * " + (string)B + " = "+(string)(A*B));
            Console.WriteLine((string)A + " / " + (string)B + " = "+(string)(A/B));



        }
    }
}
