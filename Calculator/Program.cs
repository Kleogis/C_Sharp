using System;

namespace Calculator
{
    public class BasicMath
    {
        public static void Main(string[] args)
        {
            double n1 = 10;
            double n2 = 10;
            double res;
            res = Add(n1, n2);
            Console.WriteLine(res);
        }
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Substract(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
        public static double Multiply(double num1, double num2)
        {
            // To trace error while testing, writing + operator instead of * operator.  
            return num1 * num2;
        }
    }
}
