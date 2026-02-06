using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBook
{
    internal class AddressBook : IAddressBookOperations
    {
        private List<ContactPerson> contacts = new List<ContactPerson>();

        // UC1 + UC6
        public void AddContact()
        {
            ContactPerson person = new ContactPerson();

            Console.Write("First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            person.LastName = Console.ReadLine();

            if (contacts.Contains(person))
            {
                Console.WriteLine("Duplicate contact not allowed.");
                return;
            }

            Console.Write("Address: ");
            person.Address = Console.ReadLine();

            Console.Write("City: ");
            person.City = Console.ReadLine();

            Console.Write("State: ");
            person.State = Console.ReadLine();

            Console.Write("Zip: ");
            person.Zip = Console.ReadLine();

            Console.Write("Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            Console.Write("Email: ");
            person.Email = Console.ReadLine();

            contacts.Add(person);
            Console.WriteLine("Contact added successfully.");
        }

        // UC2 – Edit using Name
        public void EditContact()
        {
            Console.Write("Enter First Name to Edit: ");
            string name = Console.ReadLine();

            var person = contacts.FirstOrDefault(
                p => p.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (person == null)
            {
                Console.WriteLine("Contact not found.");
                return;
            }

            Console.Write("New City: ");
            person.City = Console.ReadLine();

            Console.Write("New State: ");
            person.State = Console.ReadLine();

            Console.WriteLine("Contact updated.");
        }

        // UC3 – Delete using Name
        public void DeleteContact()
        {
            Console.Write("Enter First Name to Delete: ");
            string name = Console.ReadLine();

            var person = contacts.FirstOrDefault(
                p => p.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (person == null)
            {
                Console.WriteLine("Contact not found.");
                return;
            }

            contacts.Remove(person);
            Console.WriteLine("Contact deleted.");
        }

        // UC4
        public void DisplayContacts()
        {
            foreach (var person in contacts)
            {
                Console.WriteLine(person);
            }
        }

        // UC10 – Sort using Collection Library
        public void SortByName()
        {
            contacts = contacts
                .OrderBy(p => p.FirstName)
                .ThenBy(p => p.LastName)
                .ToList();

            Console.WriteLine("Contacts sorted by name.");
        }

        public List<ContactPerson> GetContacts()
        {
            return contacts;
        }
    }
}
