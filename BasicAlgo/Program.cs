using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace BasicAlgo
{
    internal class Program
    {
        //create a program that accepts the input of 2 numbers if the two numbers are the same then imput the sum multiplied by 3


        public static int GetSum(int num1,  int num2)
        {
            int sum = num1 + num2;
            return num1 == num2 ? sum * 3 : sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers separated by a comma (e.g., 1, 2):");
            string input = Console.ReadLine();

            string[] numbers = input.Split(',');
            if (numbers.Length != 2)
            {
                Console.WriteLine("Invalid input. Please enter two numbers separated by a comma.");
                return;
            }

            int num1, num2;
            if (!int.TryParse(numbers[0], out num1) || !int.TryParse(numbers[1], out num2))
            {
                Console.WriteLine("Invalid input. Please enter numerical values.");
                return;
            }

            int result = GetSum(num1, num2);
            Console.WriteLine("The sum is: {0}", result);
        }
       
    }
}
