namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            AddressBook book = new AddressBook();
            IAdressBookOperations operation;

            while (true)
            {
                Console.WriteLine("\n1.Add  2.Edit  3.Delete  4.Display  5.Sort  6.Exit");
                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        operation = book;
                        operation.Contact();
                        break;

                    case 2:
                        operation = book;
                        operation.EditContact();
                        break;

                    case 3:
                        operation = book;
                        operation.DeleteContact();
                        break;

                    case 4:
                        book.DisplayContacts();
                        break;

                    case 5:
                        operation = book;
                        operation.Sort();
                        break;

                    case 6:
                        return;
                }
            }
        }
    }
}
