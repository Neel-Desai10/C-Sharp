using System;

class Program
{
    static void Main(string[] args)
    {
        long numLong = 10070707;
        float numFloat = numLong;
        Console.WriteLine($"Long to Float: {numFloat}");
 
        float numFloat1 = 10.533F;
        int numInt = (int)numFloat1;
        Console.WriteLine($"Float to Int: {numInt}");

        string numString = "107";
        int convertedNum = Convert.ToInt32(numString);
        Console.WriteLine($"String to Int: {convertedNum}");
    }
}
