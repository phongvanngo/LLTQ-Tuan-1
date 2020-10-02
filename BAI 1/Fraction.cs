using System;
using MY_UTILITIES;

namespace MY_UTILITIES
{
    internal class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator=0, int denominator=1)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public void Print(string s = "")
        {
            Console.Write(this.numerator + "/" + this.denominator + s);
        }

        public void Reduce()
        {
            int LCM = MyFunction.LCM(numerator, denominator);
            numerator /= LCM;
            denominator /= LCM;
        }

        public static Fraction operator + (Fraction A,Fraction B)
        {
            Fraction Result = new Fraction();
            Result.numerator = A.numerator * B.denominator + A.denominator * B.numerator;
            Result.denominator = A.denominator * B.denominator;
            Result.Reduce();
            return Result;
        }

        public static Fraction operator - (Fraction A, Fraction B)
        {
            Fraction Result = new Fraction();
            Result.numerator = A.numerator * B.denominator - A.denominator * B.numerator;
            Result.denominator = A.denominator * B.denominator;
            Result.Reduce();
            return Result;
        }         
        
        public static Fraction operator * (Fraction A, Fraction B)
        {
            Fraction Result = new Fraction();
            Result.numerator = A.numerator * B.numerator;
            Result.denominator = A.denominator*B.denominator;
            Result.Reduce();
            return Result;
        }         
        
        public static Fraction operator / (Fraction A, Fraction B)
        {
            Fraction Result = new Fraction();
            Result.numerator = A.numerator * B.denominator;
            Result.denominator = A.denominator*B.numerator;
            return Result;
        }

        public static implicit operator string(Fraction a)
        {
            return (a.numerator + "/" + a.denominator);
        }

    }
}