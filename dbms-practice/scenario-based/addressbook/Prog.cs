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
                        "\n1. Add Contact" +
                        "\n2. Edit Contact" +
                        "\n3. Delete Contact" +
                        "\n4. Display Contacts" +
                        "\n5. Sort By Name" +
                        "\n6. Sort By City" +
                        "\n7. Sort By State" +
                        "\n8. Sort By Zip" +
                        "\n9. Search By City/State" +
                        "\n10. Count By City/State" +
                        "\n11. Save To Text File" +
                        "\n12. Save To CSV File" +
                        "\n13. Save To JSON File" +
                        "\n14. Save To Database" +
                        "\n15. Exit");

                    Console.Write("Enter choice: ");
                    if (!int.TryParse(Console.ReadLine(), out int choice))
                    {
                        Console.WriteLine("Invalid choice.");
                        continue;
                    }

                    switch (choice)
                    {
                        case 1:
                            book.AddContact();
                            break;

                        case 2:
                            book.EditContact();
                            break;

                        case 3:
                            book.DeleteContact();
                            break;

                        case 4:
                            book.DisplayContacts();
                            break;

                        case 5:
                            book.SortByName();
                            Console.WriteLine("Sorted by Name.");
                            break;

                        case 6:
                            book.SortByCity();
                            Console.WriteLine("Sorted by City.");
                            break;

                        case 7:
                            book.SortByState();
                            Console.WriteLine("Sorted by State.");
                            break;

                        case 8:
                            book.SortByZip();
                            Console.WriteLine("Sorted by Zip.");
                            break;

                        case 9:
                            Console.Write("Enter City or State: ");
                            string value = Console.ReadLine() ?? "";
                            system.SearchByCityOrState(value);
                            break;

                        case 10:
                            system.CountByCityAndState();
                            break;

                        case 11:
                            book.Save(new FileDataSource());
                            Console.WriteLine("Saved to Text File.");
                            break;

                        case 12:
                            book.Save(new CsvDataSource());
                            Console.WriteLine("Saved to CSV File.");
                            break;

                        case 13:
                            book.Save(new JsonDataSource());
                            Console.WriteLine("Saved to JSON File.");
                            break;

                        case 14:
                            book.Save(new DatabaseDataSource());
                            Console.WriteLine("Saved to Database.");
                            break;

                        case 15: // Exit
                            Console.WriteLine("Exiting Program.");
                            return;

                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}