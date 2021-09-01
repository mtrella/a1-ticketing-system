using System;
using System.IO;

namespace TicketingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "tickets.csv";
            string choice;
            do
            {
                //question
                Console.WriteLine("1) Read data from file.");
                Console.WriteLine("2) Create file from data.");
                Console.WriteLine("3) Enter anything else to exit.");

                choice = Console.ReadLine();

                if (choice == "1")
                {
                    if (File.Exists(file))
                    {
                        StreamReader sr = new StreamReader(file);
                        Console.WriteLine(sr.ReadToEnd());
                    }
                    else
                    {
                        Console.WriteLine("File does not exist");
                    }
                }
                else if (choice == "2")
                {
                    StreamWriter sw = new StreamWriter(file);
                    for (int i = 0; i < 7; i++)
                    {
                        Console.WriteLine("Fill out a ticket? (Y/N)?");
                        string response = Console.ReadLine().ToUpper();
                        if (response != "Y") { break; }
                        Console.WriteLine("Enter a Ticket ID:");
                        string ticketID = Console.ReadLine();
                        Console.WriteLine("Enter a summary: ");
                        string summary = Console.ReadLine();
                        Console.WriteLine("Enter a status: ");
                        string status = Console.ReadLine();
                        Console.WriteLine("Enter a priority: ");
                        string priority = Console.ReadLine();
                        Console.WriteLine("Submitter: ");
                        string submitter = Console.ReadLine();
                        Console.WriteLine("Assigned: ");
                        string assigned = Console.ReadLine();
                        Console.WriteLine("Watching: ");
                        string watching = Console.ReadLine();
                        Console.WriteLine("Enter another name? (Y/N)?");
                        string wName = Console.ReadLine().ToUpper();
                        if (wName != "Y") { break; }
                        Console.WriteLine($"{ticketID},{summary},{status},{priority},{submitter},{assigned},{watching}");
                    }
                    sw.Close();
                }
            } while (choice == "1" || choice == "2");
        }
    }
}
