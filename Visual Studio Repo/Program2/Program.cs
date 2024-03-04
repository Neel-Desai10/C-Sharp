using System;

namespace Program2
{
    class PositiveOrNegative
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine($"{num} is a positive number");
            }
            else if( num < 0 ) 
            {
                Console.WriteLine($"{num} is a negative number");
            }
            else {
                Console.WriteLine($"Number entered is zero");
            }
        } 

    }
}
