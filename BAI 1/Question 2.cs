using System;
using System.Collections.Generic;
using System.Text;
using MY_UTILITIES;

namespace DAY_1
{
    partial class Program
    {
        public static void Question_2()
        {
            Console.WriteLine("\nCau 2 ");
            Console.Write("Enter array length: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[n];

            int sum = 0;
            int num_of_prime_number = 0;
            int min_square_number = Int32.MaxValue;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"element {i}: ");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach(int element in myArray)
            {
                sum += element;
                if (MyFunction.isPrimeNumber(element)) num_of_prime_number++;
                if (MyFunction.isSquareNumber(element) && element < min_square_number) min_square_number = element;
            }

            if (min_square_number == Int32.MaxValue) min_square_number = -1;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Number of Prime Number: " + num_of_prime_number);
            Console.WriteLine("Min Square Number: " +  min_square_number);
            
        }

    }
}
