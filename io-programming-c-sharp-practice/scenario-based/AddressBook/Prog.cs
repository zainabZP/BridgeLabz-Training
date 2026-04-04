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
                        "\n1.Add" +
                        "\n2.Edit" +
                        "\n3.Delete" +
                        "\n4.Display" +
                        "\n5.Sort By Name" +
                        "\n6.Sort By City" +
                        "\n7.Sort By State" +
                        "\n8.Sort By Zip" +
                        "\n9.Search City/State" +
                        "\n10.Count City/State" +
                        "\n11.Save To Text File" +
                        "\n12.Save To CSV File" +
                        "\n13.Save To JSON File" +
                        "\n14.Exit");

                    Console.Write("Enter choice: ");

                    int choice;
                    if (!int.TryParse(Console.ReadLine(), out choice))
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
                            system.SearchByCityOrState(Console.ReadLine() ?? "");
                            break;

                        case 10:
                            system.CountByCityAndState();
                            break;

                        // UC13–UC18 (Using Open/Closed Principle)
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
