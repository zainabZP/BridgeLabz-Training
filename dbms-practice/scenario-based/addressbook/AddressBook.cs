
using System;
using System.Collections.Generic;

namespace AddressBook
{
    internal class AddressBook : IAddressBookOperations
    {
        private List<ContactPerson> contacts = new List<ContactPerson>();

        public void AddContact()
        {
            ContactPerson person = new ContactPerson();

            Console.Write("First Name: ");
            person.FirstName = Console.ReadLine() ?? "";

            Console.Write("Last Name: ");
            person.LastName = Console.ReadLine() ?? "";

            foreach (var p in contacts)
            {
                if (p.FirstName.Equals(person.FirstName, StringComparison.OrdinalIgnoreCase) &&
                    p.LastName.Equals(person.LastName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Duplicate contact not allowed.");
                    return;
                }
            }

            Console.Write("Address: ");
            person.Address = Console.ReadLine() ?? "";

            Console.Write("City: ");
            person.City = Console.ReadLine() ?? "";

            Console.Write("State: ");
            person.State = Console.ReadLine() ?? "";

            Console.Write("Zip: ");
            person.Zip = Console.ReadLine() ?? "";

            Console.Write("Phone: ");
            person.PhoneNumber = Console.ReadLine() ?? "";

            Console.Write("Email: ");
            person.Email = Console.ReadLine() ?? "";

            contacts.Add(person);
        }

        public void DisplayContacts()
        {
            foreach (var p in contacts)
                Console.WriteLine(p);
        }

        public void EditContact() { /* same as your existing */ }
        public void DeleteContact() { /* same as your existing */ }

        // UC11
        public void SortByName()
        {
            contacts.Sort();
        }

        // UC12
        public void SortByCity()
        {
            contacts.Sort((a, b) => a.City.CompareTo(b.City));
        }

        public void SortByState()
        {
            contacts.Sort((a, b) => a.State.CompareTo(b.State));
        }

        public void SortByZip()
        {
            contacts.Sort((a, b) => a.Zip.CompareTo(b.Zip));
        }

        public List<ContactPerson> GetContacts()
        {
            return contacts;
        }

        // UC18 (Open Closed Principle)
        public async void Save(IDataSource source)
        {
            await source.SaveAsync(contacts);
        }
    }
}
