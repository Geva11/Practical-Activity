using System;

namespace CalculatorMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Operation to be used: ");
            Console.WriteLine("[1] ADD\n[2] SUBTRACT\n[3] MULTIPLY\n[4] DIVIDE");
            Console.Write("Operation: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case 1:
                    result = Add(num1, num2);
                    Console.WriteLine("Adding " + num1 + " and " + num2 + " the result is " + result);
                    break;
                case 2:
                    if (num1 < num2)
                    {
                        Console.WriteLine("Invalid input. For subtraction, the first number should be greater than the second number.");
                        return;
                    }
                    result = Subtract(num1, num2);
                    Console.WriteLine("Subtracting " + num2 + " from " + num1 + " the result is " + result);
                    break;
                case 3:
                    result = Multiply(num1, num2);
                    Console.WriteLine("Multiplying " + num1 + " and " + num2 + " the result is " + result);
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Invalid input. Division by zero is not allowed.");
                        return;
                    }
                    else if (num1 < num2)
                    {
                        Console.WriteLine("Invalid input. For dividing, the first number should be greater than the second number.");
                        return;
                    }
                    result = Divide(num1, num2);
                    Console.WriteLine("Dividing " + num1 + " by " + num2 + " the result is " + result);
                    break;
                default:
                    Console.WriteLine("Invalid input. Please select a valid operation.");
                    break;
            }
        }

        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}