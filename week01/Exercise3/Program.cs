using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string play ="";
        
        do // this loop is for playing the game again
        {
            Console.Write("What is your Magic Number? "); // ask question
            string number = Console.ReadLine(); // choose number
            int magicNumber = int.Parse(number); // convert to int
            int x;   // declare x outside the do 
            int guessCount = 0;  //declare count outside   

            do // this loop is for the guess the number game
            {
                guessCount++; //body: add each guess until right
                
                Console.Write("Guess the number? "); // body: guess number
                string y = Console.ReadLine();  // body:declare y
                x = int.Parse(y);  // body:convert string to int

                if (x == magicNumber) // body: 1st condition
                {
                    Console.WriteLine($"You guessed it. it took {guessCount} guesses"); // Answer and count code stops                   
                }
                else if (x > magicNumber) // body: 2nd condition
                {
                    Console.WriteLine("lower"); // Answer: too high needs to come down
                }
                else
                {
                    Console.WriteLine("higher"); //Answer: too low needs to be higher
                }
            
            } while (x != magicNumber);//guess until right

            Console.WriteLine($"Want to play again");
            play = Console.ReadLine();

        } while(play == "yes");

    }
}