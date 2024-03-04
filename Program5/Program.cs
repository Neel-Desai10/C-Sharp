namespace Program5;

class Program
{
   static void Main(string[] args)
    {
        Console.Write("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        long factorial = ComputeFactorial(number);
        
        Console.WriteLine("Factorial of " + number + " is: " + factorial);
    }

    static long ComputeFactorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Number cannot be negative.");
        }
        else if (number == 0 || number == 1)
        {
            return 1;
        }
        else
        {
            long result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
