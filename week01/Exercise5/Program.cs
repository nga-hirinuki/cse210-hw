using System;

class Program
{
    static void Main(string[] args)
    {
        {
            string fullName = PromptUserName("first name", "last name"); // declare variable and call method 
            int favouriteNumber = PromptUserNumber(); // declare variable and call method 
            int squared = SquareNumber(favouriteNumber); // declare variable and call method 

            DisplayWelcome(); // call method to run
            Console.WriteLine($"Welcome, {fullName}!"); // Call UserPromptName method 
            Console.WriteLine($"Your Favourite number is {favouriteNumber}"); // Call UserPromptNumber method 
            Console.WriteLine($"{fullName}, the square of your number is {squared}\n"); // Call SquaredNumber method 
        }

        // DisplayWelcome - Displays the message, "Welcome to the Program!"

        static void DisplayWelcome() //Declare function of method
        {
            Console.WriteLine("Welcome to the Program!");
        }

        // PromptUserName - Asks for and returns the user's name (as a string)

        static string PromptUserName(string firstName, string lastName) // declare string method
        {
            Console.Write($"What is your {firstName} "); // body: ask user
            string userName = Console.ReadLine();        // body: declare variable and input user answer
            Console.Write($"What is your {lastName} ");  // body: ask user
            string userLastName = Console.ReadLine();    // body: declare variable and input user answer

            return $"{userName} {userLastName}";    // return fullname from variables
        }

        // PromptUserNumber - Asks for and returns the user's favorite number (as an integer) 

        static int PromptUserNumber() // declare string method
        {
            Console.Write($"What is your favourite number "); // body: ask user
            string userNumber = Console.ReadLine(); // body: input user number
            int number = int.Parse(userNumber); // body: declare variable and convert to integer

            return number;    // return number from variables
        }

        //SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)

        static int SquareNumber(int number)
        {
            int square = number * number; // body: declare variable and calculate square
            
            return square; // return value from variables
        }

    }
}