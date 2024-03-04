namespace Program6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsArmstrong(number))
        {
            Console.WriteLine(number + " is an Armstrong number.");
        }
        else
        {
            Console.WriteLine(number + " is not an Armstrong number.");
        }
    }

    static bool IsArmstrong(int number)
    {
        int originalNumber = number;
        int numberOfDigits = GetNumberOfDigits(number);
        int sum = 0;

        while (number > 0)
        {
            int digit = number % 10;
            sum += (int)Math.Pow(digit, numberOfDigits);
            number /= 10;
        }

        return originalNumber == sum;
    }

    static int GetNumberOfDigits(int number)
    {
        int count = 0;
        while (number != 0)
        {
            number /= 10;
            ++count;
        }
        return count;
    }
}
