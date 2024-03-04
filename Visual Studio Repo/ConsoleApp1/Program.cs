namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {

            Stack<int> stack = new Stack<int>();

            stack.Push(5);

            Console.WriteLine(stack);



        }

        public static int Myfun(int x)
        {
           return x * x * x;
        }


    }
}