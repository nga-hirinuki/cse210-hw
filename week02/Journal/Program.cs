using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();  // Create Journal instance
        PromptGenerator promptGenerator = new PromptGenerator();// Create prompt instance
                 
        Console.WriteLine("Welcome to the Journal Program! ");
    
        int choice = 0; // for the while loop

        do // this loop if 5 is not pressed
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit  ");
            Console.Write("What would you like to do?: "); // body: guess number
            string number = Console.ReadLine();
            choice = int.Parse(number);

            if (choice == 1) // body: Write a post
            {
                Console.Write("Enter the date (e.g., day/date/month/year): ");
                string date = Console.ReadLine();

                string prompt = promptGenerator.GetRandomPrompt(); // Using the generator 
                Console.WriteLine($"{prompt}");// Generate a prompt

                Console.Write("Enter your journal entry: ");
                string entryText = Console.ReadLine(); 

                Entry newEntry = new Entry
                {
                    _date = date,
                    _promptText = prompt,
                    _entryText = entryText,
                };
                // from myJournal(local) store my entry in the Entry file as a new entry 
                myJournal.AddEntry(newEntry); 
                Console.WriteLine("Entry successfully added!");        
            }
            else if (choice == 2) // body: Display all Entries
            {
                Console.WriteLine("Display all your journal entries:");
                myJournal.DisplayAll();
            }
            else if (choice == 3) // body: Load the file
            {
                Console.Write("Enter the filename to load from (e.g., journal.txt): ");
                string fileName = Console.ReadLine();

                {
                    myJournal.LoadFromFile(fileName);
                    Console.WriteLine($"Journal entries have been loaded from {fileName}.");
                    myJournal.DisplayAll(); // Add this to confirm entries are successfully loaded
                }
            }
            else if (choice == 4) // Save entries
            {
                Console.Write("Enter the filename to save to (e.g., journal.txt): ");
                string fileName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(fileName))
                {
                    Console.WriteLine("Invalid file name. Please try again.");
                }
                else
                {
                    myJournal.SaveToFile(fileName);
                    Console.WriteLine($"Journal entries have been saved to {fileName}.");
                }
            }
            else
            {
                Console.WriteLine("You have chosen to quit"); //quit program
            }
        
        } while (choice != 5);//guess until right

    }
}