namespace Program9;

class Program
{
    static void Main(string[] args)
    {
        string validUserId = "admin";
        string validPassword = "password";
        int attempts = 0;

        while (attempts < 3)
        {
            Console.Write("Enter User ID: ");
            string userId = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (userId == validUserId && password == validPassword)
            {
                Console.WriteLine("Login successful!");
                break;
            }
            else
            {
                attempts++;
                Console.WriteLine("Invalid User ID or Password. Attempts remaining: " + (3 - attempts));
            }
        }

        if (attempts == 3)
        {
            Console.WriteLine("Too many unsuccessful attempts. Access denied.");
        }
    }
}
