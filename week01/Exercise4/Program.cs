using System;
using System.Collections.Generic;
using System.Transactions;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();// Declare and initialize the list
        Console.WriteLine(" a list of numbers, type 0 when finished "); // ask question
        int number; // Declare number variable
        float total;// Declare total variable
        float average;// Declare average variable
        do
        {
            Console.Write("Enter number? "); // body: guess number
            number = int.Parse(Console.ReadLine());// convert string to int

            if (number != 0) // declare conditions
            {
                numbers.Add(number); // entered number is added to list
            }

        } while (number != 0);//guess until right

        total = numbers.Sum(); // declare sum of numbers in the list
        average = total / numbers.Count;// use total divide / number in list

        int largest = numbers[0]; // declare variable
        foreach (int num in numbers) // look into list 
        {
            if (num > largest) // show condition to find largest
            {
                largest = num; // show large number
            }
        }
        Console.WriteLine($"Total {total}");
        Console.WriteLine($"Count {numbers.Count}");
        Console.WriteLine($"Average {average:F2}");
        Console.WriteLine($"Largest {total}");
    }
}