using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();           /* number one */
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            int squaredNumber = SquareNumber(userNumber);
            DisplayResult(userName , squaredNumber);
    }
    static void DisplayWelcome()    /* number one */            
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()    /* number two */    
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
        
    } 
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favourite number: ");
        string number = Console.ReadLine();
        int x = int.Parse(number);
        return x;
    } 
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(string user,int SquareNumber)
    {
        Console.Write($"{user}, the square of your number is {SquareNumber}");
    }
}