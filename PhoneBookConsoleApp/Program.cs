using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the Console PhoneBook App");
            Console.WriteLine("Select operation");
            Console.WriteLine("1 Add Contact");
            Console.WriteLine("2 Display Contact by number");
            Console.WriteLine("3 View all contacts");
            Console.WriteLine("4 Search for a contact for a given name");
            Console.WriteLine("Press X to exit the application");

            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Input contact name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Input contact number:");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);
                        break;
                    case "2":
                        Console.WriteLine("Contact number to search:");
                        var searchNumber = Console.ReadLine();
                        phoneBook.DisplayContact(searchNumber);
                        break;
                    case "3":
                        phoneBook.DisplayAllContacts();
                        break;
                    case "4":
                        Console.WriteLine("Name search phrase");
                        var searchPhrase = Console.ReadLine();

                        phoneBook.DisplayMatchingContacts(searchPhrase);
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Select valid operation");
                        break;

                }

                Console.WriteLine("Select operation");
                userInput = Console.ReadLine();
            }
        }
    }
}
