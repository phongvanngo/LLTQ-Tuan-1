using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MY_UTILITIES
{
    class MyFunction
    {
        public static bool isLeapYear(int year)
        {
            if (year % 4 != 0) return false;
            if (year % 100 == 0) return false;
            if (year % 400 == 0) return false;
            return true;
        }
        public static bool isPrimeNumber(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public static bool isSquareNumber(int n)
        {
            int i = 1;
            while (i <= n)
            {
                if (i * i == n) return true;
                i++;
            }
            return false;
        }

        public static int sumOfArray(int[] arr)
        {
            int result = 0;
            foreach (int element in arr) result += element;
            return result;
        }

        public static int maxNumberInArray(int[] arr)
        {
            int max_number = 0;
            foreach (int element in arr) if (element > max_number) max_number = element;
            return max_number;
        }

        public static int sumNotPrimeNumberInArray(int[] arr)
        {
            int result = 0;
            foreach (int element in arr) if (!isPrimeNumber(element)) result += element;
            return result;
        }

        public static int LCM(int a, int b)
        {
            int temp = a % b;
            while (temp!=0)
            {
                a = b;
                b = temp;
                temp = a % b;
            }
            return b;
        }
    }
}
