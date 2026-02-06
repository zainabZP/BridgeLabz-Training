using System;
using System.Collections.Generic;

namespace AddressBook
{
    internal class AddressBookSystem
    {
        private Dictionary<string, AddressBook> addressBooks =
            new Dictionary<string, AddressBook>();

        // UC5
        public AddressBook GetAddressBook(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Address Book name cannot be empty.");

            if (!addressBooks.ContainsKey(name))
            {
                addressBooks[name] = new AddressBook();
                Console.WriteLine("New Address Book created.");
            }

            return addressBooks[name];
        }

        // UC8
        public void SearchByCityOrState(string value)
        {
            foreach (var book in addressBooks.Values)
            {
                foreach (var person in book.GetContacts())
                {
                    if (person.City.Equals(value, StringComparison.OrdinalIgnoreCase) ||
                        person.State.Equals(value, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(person);
                    }
                }
            }
        }

        // UC9
        public void CountByCityAndState()
        {
            Dictionary<string, int> cityCount = new Dictionary<string, int>();
            Dictionary<string, int> stateCount = new Dictionary<string, int>();

            foreach (var book in addressBooks.Values)
            {
                foreach (var person in book.GetContacts())
                {
                    if (!cityCount.ContainsKey(person.City))
                        cityCount[person.City] = 0;
                    cityCount[person.City]++;

                    if (!stateCount.ContainsKey(person.State))
                        stateCount[person.State] = 0;
                    stateCount[person.State]++;
                }
            }

            Console.WriteLine("\nCount by City:");
            foreach (var c in cityCount)
                Console.WriteLine(c.Key + ": " + c.Value);

            Console.WriteLine("\nCount by State:");
            foreach (var s in stateCount)
                Console.WriteLine(s.Key + ": " + s.Value);
        }
    }
}
