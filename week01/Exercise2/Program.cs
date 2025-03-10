using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string number = Console.ReadLine();
        int grade = int.Parse(number);
        string letter = "";
        string sign = "";
        

        if (grade >= 90)
            {
            letter = "A";
            }
            else if (grade >= 80)
            {
            letter = "B";
            }
            else if (grade >= 70)
            {
            letter = "C";
            }
            else if (grade >= 60)
            {
            letter = "D";
            }
            else
            {
            letter = "E";
            }
        
        float divide = grade/10f;
        int signage = grade/10;
        float deci = (divide - signage) * 10;

        if (deci >= 7)
            {
            sign = "+";
            }
            else if (deci <= 3)
            {
            sign = "-";
            }
            else
            {
            sign = " ";
            }

        Console.Write($"{letter}{sign}   {deci:F0} ");
        
        if (grade > 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed!");
        }
    }
        
}