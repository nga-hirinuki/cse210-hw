using System;
using System.IO.Compression;
using System.Runtime.CompilerServices;

Console.Write("What is your grade percentage: ");
string letter = Console.ReadLine();
int x = int.Parse(letter);
float y = x / 10f;
float z = y - (x/10);

if (x >= 90 || x >= 80 || x >= 70 || x >= 60 || x < 60 && z >.7 || z <= .3)
{
    
    if (x >= 90 )
    {
        Console.Write($"Full Scholarship. Your grade is an A");
        if (z >= .69)
        {
            Console.WriteLine("+");
        }
        else if (z <= .31)
        {
            Console.WriteLine("-");
        }
        else  
        {
            Console.WriteLine();
        }
    }

    else if (x >= 80)
    {
        Console.Write("Great Score. Your grade is an B");
        if (z >= .69)
        {
            Console.WriteLine("+");
        }
        else if (z <= .31)
        {
            Console.WriteLine("-");
        }
        else  
        {
            Console.WriteLine();
        }
    }
    else if (x >= 70)
    {
        Console.Write("Cutting it close. Your grade is an C");
        if (z >= .69)
        {
            Console.WriteLine("+");
        }
        else if (z <= .31)
        {
            Console.WriteLine("-");
        }
        else  
        {
            Console.WriteLine();
        }
    }
    else if (x >= 60)
    {
        Console.Write("Need more Study. Your grade is an D");
        if (z >= .69)
        {
            Console.WriteLine("+");
        }
        else if (z <= .31)
        {
            Console.WriteLine("-");
        }
        else  
        {
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("Repent Now. Your grade is an F");
    }
}
