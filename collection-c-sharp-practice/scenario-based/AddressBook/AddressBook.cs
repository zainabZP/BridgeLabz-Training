using System;
using System.Collections.Generic;

namespace AddressBook
{
    internal class AddressBook : IAddressBookOperations
    {
        private List<ContactPerson> contacts = new List<ContactPerson>();

        // UC1 + UC6
        public void AddContact()
        {
            try
            {
                ContactPerson person = new ContactPerson();

                Console.Write("First Name: ");
                person.FirstName = Console.ReadLine() ?? "";

                Console.Write("Last Name: ");
                person.LastName = Console.ReadLine() ?? "";

                // Duplicate check using loop
                foreach (ContactPerson p in contacts)
                {
                    if (p.Equals(person))
                        throw new Exception("Duplicate contact not allowed.");
                }

                Console.Write("Address: ");
                person.Address = Console.ReadLine() ?? "";

                Console.Write("City: ");
                person.City = Console.ReadLine() ?? "";

                Console.Write("State: ");
                person.State = Console.ReadLine() ?? "";

                Console.Write("Zip: ");
                person.Zip = Console.ReadLine() ?? "";

                Console.Write("Phone Number: ");
                person.PhoneNumber = Console.ReadLine() ?? "";

                Console.Write("Email: ");
                person.Email = Console.ReadLine() ?? "";

                contacts.Add(person);
                Console.WriteLine("Contact added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // UC2
        public void EditContact()
        {
            Console.Write("Enter First Name to Edit: ");
            string name = Console.ReadLine() ?? "";

            foreach (ContactPerson p in contacts)
            {
                if (p.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("New City: ");
                    p.City = Console.ReadLine() ?? "";

                    Console.Write("New State: ");
                    p.State = Console.ReadLine() ?? "";

                    Console.WriteLine("Contact updated.");
                    return;
                }
            }

            Console.WriteLine("Contact not found.");
        }

        // UC3
        public void DeleteContact()
        {
            Console.Write("Enter First Name to Delete: ");
            string name = Console.ReadLine() ?? "";

            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].FirstName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    contacts.RemoveAt(i);
                    Console.WriteLine("Contact deleted.");
                    return;
                }
            }

            Console.WriteLine("Contact not found.");
        }

        // UC4
        public void DisplayContacts()
        {
            foreach (ContactPerson p in contacts)
            {
                Console.WriteLine(p);
            }
        }

        // UC10 – Sorting (manual, no LINQ)
        public void SortByName()
        {
            for (int i = 0; i < contacts.Count - 1; i++)
            {
                for (int j = i + 1; j < contacts.Count; j++)
                {
                    if (contacts[i].FirstName.CompareTo(contacts[j].FirstName) > 0)
                    {
                        ContactPerson temp = contacts[i];
                        contacts[i] = contacts[j];
                        contacts[j] = temp;
                    }
                }
            }

            Console.WriteLine("Contacts sorted by name.");
        }

        public List<ContactPerson> GetContacts()
        {
            return contacts;
        }
    }
}
