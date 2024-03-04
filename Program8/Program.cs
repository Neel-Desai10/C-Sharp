namespace Program8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the width of the triangle:");
        int width = int.Parse(Console.ReadLine());

        Console.WriteLine("Reverse Triangle:");
        // Loop to iterate over each row of the reverse triangle
        for (int i = width; i >= 1; i--)
        {
            // Loop to iterate over each column of the current row
            for (int j = 1; j <= i; j++)
            {
                // Print the number with appropriate spacing
                Console.Write($"{number} ");
            }
            Console.WriteLine(); // Move to the next line for the next row
        }
    }
}
