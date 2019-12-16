 using System;

namespace OOP_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Select operation:\n[1]Addition\n[2]Subtraction\n[3]Multiplication\n[4]Division\n");
            int operation = Convert.ToInt32(Console.ReadLine());
            if (operation == 1)
            {
                Add(number1, number2);
            }
            if (operation == 2) 
            {
                Subtract(number1, number2);
            }
            if (operation == 3) 
            {
                Multiply(number1, number2);
            }
            if (operation == 4) 
            {
                Divide(number1, number2);
            }
        }
        static void Add(int num1, int num2)
        {
            Console.Write("The sum is: ");
            Console.Write(num1 + num2);
        }
        static void Subtract(int num1, int num2)
        {
            Console.Write("The difference is: ");
            Console.Write(num1 - num2);
        }
        static void Divide(int num1, int num2)
        {
            Console.Write("The quotient is: ");
            Console.Write(num1 / num2);
        }
        static void Multiply(int num1, int num2)
        {
            Console.Write("The product is: ");
            Console.Write(num1 * num2);
        }
    }
}

