using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {


        Console.Write("Enter a list of numbers, type 0 when finished.");    /* purpose of list  */

        List<int> numbers = new List<int>();             /* where to store integers*/
        int y = -1;                                     /* declare base of y int */



        while (y != 0)                                     /* if userinput doesn't type 0, run the program in a loop */
        {
            Console.Write("Enter number: ");            /* ask user for number */
            string userinput = Console.ReadLine();      /* out string */
            y = int.Parse(userinput);                   /* need to convert string to int */

            if (y != 0)                                 /* if y isnt 0 add number to list */
            {
                numbers.Add(y);                         /* .Add is what adds number to list */
            }
            else
            {
                int sum = numbers.Sum();                /* .Sum adds all the numbers in the list */    
                double average = numbers.Average();     /* .Average = adds all the numbers and divides by the amount of item */ 
                double maxNumber = numbers.Max();       /* .Max = from the list find the highest number */ 
                double minNumber = numbers.Min();       /* .Min = find the lowest from the list */ 
                
               
                Console.WriteLine($"The sum is: {sum}");            
                Console.WriteLine($"The average is: {average}");      
                Console.WriteLine($"The average is: {maxNumber}");      
                Console.WriteLine($"The average is: {minNumber}");        
                
            }
            
        }



    }
}