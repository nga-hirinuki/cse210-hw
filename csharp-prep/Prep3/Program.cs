using System;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
      
        Console.Write("What is the magic number? "); /* Question */
        
        string magicNumber = Console.ReadLine();    /* Ask for nummber */    
        int x = int.Parse(magicNumber);             /* change string to int */
        int y = 0;                                  /* declare y as a variable */
        int guessCount =0;                          /* declare start of count */

        while( y != x)                              /* if y doesn't equal x then run loop until it is right */
        {
            Console.Write("What is your guess? ");  /* Ask guess question */
            string guess = Console.ReadLine();      /* userinput number */    
            y = int.Parse(guess);                   /* convert string to int */

            guessCount++;                           /* each loop will add 1 to total count */
            
            if (y > x)                              /* if guess is higher than x */
                {
                    Console.WriteLine("Lower");     /* Inform user number is lower */
                }
                else if (y < x)                     /* if guess is lower than x */
                {
                    Console.WriteLine("Higher");    /* Inform user number is higher */
                }
                else                                /* Guess is right */
                {
                    Console.WriteLine($"You guessed it! You guessed it in {guessCount} moves"); /* Right Answer with guessCount */   
                }
        }
        
        
    }
}