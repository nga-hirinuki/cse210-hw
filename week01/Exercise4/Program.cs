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
        int number;
        float total;
        float average;
        do
        {
            Console.Write("Enter number? "); // body: guess number
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);//guess until right

        total = numbers.Sum();
        average = total / numbers.Count;

        int largest = numbers[0];
        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }

        Console.WriteLine($"Total {total}");
        Console.WriteLine($"Count {numbers.Count}");
        Console.WriteLine($"Average {average:F2}");
        Console.WriteLine($"Largest {total}");
    }
}