namespace Prgram1;

class Program
{
    static void Main(string[] args)
    {
      Console.Write("Enter an integer: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int n;

        while (number > 0)
        {
           n = number % 10;
           sum += n;
           number = number / 10;
        }

        Console.WriteLine("Sum of the digit of the said integer: " + sum);
    }
}
