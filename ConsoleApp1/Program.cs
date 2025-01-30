using System;

class Program
{
    static void Main(string[] args)
    {
        int attempts = 3;
        while (attempts > 0)
        {
            if (Login())
            {
                Console.WriteLine("Login successful!");
                break;
            }
            else
            {
                attempts--;
                Console.WriteLine($"Incorrect Password You have {attempts} attempt left.");
            }
        }

        if (attempts == 0)
        {
            Console.WriteLine("You've exceeded the maximum number of attempt. Please try again later.");
        }
    }

    static bool Login()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        if (username == "Admin" && password == "Admin1234!")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
