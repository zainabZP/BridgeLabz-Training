using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Address Book Program");

            AddressBookSystem system = new AddressBookSystem();

            try
            {
                Console.Write("Enter Address Book Name: ");
                string bookName = Console.ReadLine() ?? "";

                AddressBook book = system.GetAddressBook(bookName);

                while (true)
                {
                    Console.WriteLine(
                        "\n1.Add 2.Edit 3.Delete 4.Display 5.Sort 6.Search City/State 7.Count City/State 8.Exit");
                    Console.Write("Enter choice: ");

                    int choice;
                    if (!int.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.WriteLine("Invalid choice.");
                        continue;
                    }

                    switch (choice)
                    {
                        case 1: book.AddContact(); break;
                        case 2: book.EditContact(); break;
                        case 3: book.DeleteContact(); break;
                        case 4: book.DisplayContacts(); break;
                        case 5: book.SortByName(); break;
                        case 6:
                            Console.Write("Enter City or State: ");
                            system.SearchByCityOrState(Console.ReadLine() ?? "");
                            break;
                        case 7:
                            system.CountByCityAndState();
                            break;
                        case 8:
                            return;
                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
