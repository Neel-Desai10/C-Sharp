namespace Program7;

class Task7
{
    static void Main(string[] args)
    {
        char letter, letter1, letter2;

        Console.Write("Enter letter: ");
        letter = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter letter: ");
        letter1 = Convert.ToChar(Console.ReadLine());       

        Console.Write("Enter letter: ");
        letter2 = Convert.ToChar(Console.ReadLine());
        
        Console.WriteLine("{0} {1} {2}", letter2, letter1, letter);
    }
}
