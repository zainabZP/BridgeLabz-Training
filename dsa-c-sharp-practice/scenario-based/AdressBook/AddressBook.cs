namespace AddressBook
{
    internal class AddressBook:IAdressBookOperations
    {
        private static ContactPerson[] contacts = new ContactPerson[100];
        private static int count = 0;

        public static ContactPerson[] Contacts
        {
            get { return contacts; }
        }

        public static int Count
        {
            get { return count; }
            set { count = value; }
        }

        public void Contact()
        {
            Console.Write("Enter Phone Number: ");
            string phnNumber = Console.ReadLine();

            for (int i = 0; i < AddressBook.Count; i++)
            {
                if (AddressBook.Contacts[i].PhoneNumber == phnNumber)
                {
                    Console.WriteLine("Contact already exists.");
                    return;
                }
            }

            ContactPerson c = new ContactPerson();

            Console.Write("First Name: ");
            c.FirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            c.LastName = Console.ReadLine();

            Console.Write("Address: ");
            c.Address = Console.ReadLine();

            Console.Write("City: ");
            c.City = Console.ReadLine();

            Console.Write("State: ");
            c.State = Console.ReadLine();

            Console.Write("Zip: ");
            c.Zip = Console.ReadLine();

            c.PhoneNumber = phnNumber;

            Console.Write("Email: ");
            c.Email = Console.ReadLine();

            AddressBook.Contacts[AddressBook.Count] = c;
            AddressBook.Count++;

            Console.WriteLine("Contact added.");
        }

        public void DeleteContact()
        {
            Console.Write("Enter Phone Number to Delete: ");
            string number = Console.ReadLine();

            for (int i = 0; i < AddressBook.Count; i++)
            {
                if (AddressBook.Contacts[i].PhoneNumber == number)
                {
                    for (int j = i; j < AddressBook.Count - 1; j++)
                    {
                        AddressBook.Contacts[j] = AddressBook.Contacts[j + 1];
                    }
                    AddressBook.Count--;
                    Console.WriteLine("Contact deleted.");
                    return;
                }
            }
            Console.WriteLine("Contact not found.");
        }

        public void Sort()
        {
            for (int i = 0; i < AddressBook.Count; i++)
            {
                for (int j = i + 1; j < AddressBook.Count; j++)
                {
                    if (AddressBook.Contacts[i].FirstName
                        .CompareTo(AddressBook.Contacts[j].FirstName) > 0)
                    {
                        ContactPerson temp = AddressBook.Contacts[i];
                        AddressBook.Contacts[i] = AddressBook.Contacts[j];
                        AddressBook.Contacts[j] = temp;
                    }
                }
            }
            Console.WriteLine("Contacts sorted.");
        }

        public void EditContact()
        {
            Console.Write("Enter Phone Number to Edit: ");
            string phnNumber = Console.ReadLine();

            for (int i = 0; i < AddressBook.Count; i++)
            {
                if (AddressBook.Contacts[i].PhoneNumber == phnNumber)
                {
                    Console.Write("New Name: ");
                    AddressBook.Contacts[i].FirstName = Console.ReadLine();

                    Console.Write("New City: ");
                    AddressBook.Contacts[i].City = Console.ReadLine();

                    Console.WriteLine("Contact updated.");
                    return;
                }
            }
            Console.WriteLine("Contact not found.");
        }

        public void DisplayContacts()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(
                    contacts[i].FirstName + " " +
                    contacts[i].LastName + ", " +
                    contacts[i].City + ", " +
                    contacts[i].PhoneNumber
                );
            }
        }
    }
}
