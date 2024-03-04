namespace Program10;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("Enter Roll Number: ");
        int rollNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Marks of Subject 1: ");
        int subject1Marks = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Marks of Subject 2: ");
        int subject2Marks = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Marks of Subject 3: ");
        int subject3Marks = Convert.ToInt32(Console.ReadLine());

        int totalMarks = subject1Marks + subject2Marks + subject3Marks;

        double percentage = (double)totalMarks / 3;

        string division;
        if (percentage >= 60)
        {
            division = "First";
        }
        else if (percentage >= 45)
        {
            division = "Second";
        }
        else if (percentage >= 33)
        {
            division = "Third";
        }
        else
        {
            division = "Fail";
        }

        Console.WriteLine("\nRoll Number: " + rollNumber);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Total Marks: " + totalMarks);
        Console.WriteLine("Percentage: " + percentage.ToString("0.00") + "%");
        Console.WriteLine("Division: " + division);
    }
}
