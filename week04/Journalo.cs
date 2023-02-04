using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace JournalApp
{
    class Journal
    {
        // Display the Introduction, Show menu to select from the options.
        public void Run()
        {
            Title = "Journal APP";
            DisplayIntro();
            DisplayJournalContents();
            RunMenu();

            DisplayOutro();
        }

        public void RunMenu()
        {   
            string choice;
            do
            {
            
              choice = GetChoice();
              switch (choice)
              {
                case "1":
                   DisplayJournalContents();
                   break;
                case "2":
                   ClearFile();
                   break;
                case "3":
                   AddEntry();
                   break;
                default:
                   break;
              }
            }while (choice != "5");
        }

        private string GetChoice()
        {
            bool isChoiceValid = false;
            string choice = "";

         do
         {

            Clear();
            WriteLine("\nSelect an option:");
            Console.WriteLine("Please select one of the following");
            Console.WriteLine("1. Add Not To Journal");
            Console.WriteLine("2. Show Journal File");
            Console.WriteLine("3.Load Journal Note");
            Console.WriteLine("4.Save Journal Note");
            Console.WriteLine("5.Quit Journal");
            Console.Write("\r\nSelect an option:");

            choice = ReadLine().Trim();

            if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5")
            {
                isChoiceValid = true;
            }
            else
            {
                writeLine($"\"{choice}\" is not an option, please choose 1- 5.");
                waitForKey();
            }
         } while(! isChoiceValid );


            return choice;
        }

        private void CreateJournalFile() 
        {
            //writeline($"Does file exist? {File.Exists("MyJournal.txt")}");

            if (!File.Exists("myJournal.txt"))

            {
                File.Create.Text("MyJournal");
            }
        }

        private void DisplayIntro() 
        {
            foregroundColor = ConsoleColor.Black;
            BackgroundColor = ConsoleColor.White;
            ClearFile();
            writeline("Title");
            Console.WriteLine("\nWelcome to the journal app");
            ReadKey(true);
        }

        private void DisplayOutro() 
        {
            Console.WriteLine("Thanks for using the Journal");
            ReadKey();
        }

        private void waitForKey()
        {
            Writeline("\nPress any key..");
            Readkey(true);
        }

        private void DisplayJournalContents() 
        {
            string journalText = File.ReadAllText(JournalFile);
            Writeline("Journal:");
            Writeline(journalText);
        }

        private void AddEntry() 
        {
            Writeline("\nWhat would you like to add: ");
            string newline = ReadLine();
            File.AppendAllText(JournalFile, $"\nEntry:\n {newline}");
            WriteLine("The journal has been modified!");
            waitForKey();
        }

        private void ClearFile() 
        {
            File.WriteAllText(JournalFile, "");
            Writeline("\nJournal cleared!");
            waitForKey();
        }

    }
}