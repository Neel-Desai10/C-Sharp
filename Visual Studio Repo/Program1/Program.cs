using System;

namespace Program1
{
    class CheckEquality
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber == secondNumber)
            {
                Console.WriteLine($"{firstNumber} and {secondNumber} are equal");
            }
            else
            {
                Console.WriteLine($"{firstNumber} and {secondNumber} are not equal");
            }
        }
    }
}