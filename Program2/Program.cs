namespace Program_2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int numTerms = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Fibonacci Series:");
        PrintFibonacciSeries(numTerms);
    }

    static void PrintFibonacciSeries(int numTerms)
    {
        int firstTerm = 0, secondTerm = 1, nextTerm;

        for (int i = 1; i <= numTerms; ++i)
        {
            Console.Write(firstTerm + " ");

            nextTerm = firstTerm + secondTerm;
            firstTerm = secondTerm;
            secondTerm = nextTerm;
        }
    }
}
