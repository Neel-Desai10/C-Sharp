namespace program4;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPalindrome(number))
        {
            Console.WriteLine(number + " is a palindrome number.");
        }
        else
        {
            Console.WriteLine(number + " is not a palindrome number.");
        }
    }

    static bool IsPalindrome(int number)
    {
        int originalNumber = number;
        int reverseNumber = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reverseNumber = reverseNumber * 10 + digit;
            number /= 10;
        }

        return originalNumber == reverseNumber;
    }
}


