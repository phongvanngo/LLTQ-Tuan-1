using System;
using System.Collections.Generic;
using System.Text;
using MY_UTILITIES;

namespace DAY_1
{
    partial class Program
    {
        public static void Question_1()
        {
            Console.WriteLine("Cau 1: ");

            Console.Write("Enter month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            int[] num_day_in_month = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (MyFunction.isLeapYear(year)) num_day_in_month[2]++;

            Console.WriteLine($"{month}/{year} has {num_day_in_month[month]} days");
        }
    }
}
