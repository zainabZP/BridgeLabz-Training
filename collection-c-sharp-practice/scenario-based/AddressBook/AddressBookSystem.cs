using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBook
{
    internal class AddressBookSystem
    {
        private Dictionary<string, AddressBook> addressBooks =
            new Dictionary<string, AddressBook>();

        // UC5 – Multiple Address Books
        public AddressBook GetAddressBook(string name)
        {
            if (!addressBooks.ContainsKey(name))
            {
                addressBooks[name] = new AddressBook();
                Console.WriteLine("New Address Book created.");
            }
            return addressBooks[name];
        }

        // UC8 – Search by City or State
        public void SearchByCityOrState(string value)
        {
            var result = addressBooks.Values
                .SelectMany(b => b.GetContacts())
                .Where(p => p.City.Equals(value, StringComparison.OrdinalIgnoreCase)
                         || p.State.Equals(value, StringComparison.OrdinalIgnoreCase));

            foreach (var person in result)
            {
                Console.WriteLine(person);
            }
        }

        // UC9 – Count by City and State
        public void CountByCityAndState()
        {
            var allContacts = addressBooks.Values
                .SelectMany(b => b.GetContacts());

            var cityCount = allContacts.GroupBy(p => p.City);
            var stateCount = allContacts.GroupBy(p => p.State);

            Console.WriteLine("\nCount by City:");
            foreach (var c in cityCount)
            {
                Console.WriteLine($"{c.Key}: {c.Count()}");
            }

            Console.WriteLine("\nCount by State:");
            foreach (var s in stateCount)
            {
                Console.WriteLine($"{s.Key}: {s.Count()}");
            }
        }
    }
}
