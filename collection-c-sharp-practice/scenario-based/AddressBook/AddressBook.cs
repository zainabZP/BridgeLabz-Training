using System;
using System.Collections.Generic;

namespace AddressBook
{
    internal class AddressBook : IAdressBookOperations
    {
        private static LinkedList<ContactPerson> contacts = new LinkedList<ContactPerson>();

        public void Contact()
        {
            Console.Write("Enter Phone Number: ");
            string phnNumber = Console.ReadLine();

            foreach (var person in contacts)
            {
                if (person.PhoneNumber == phnNumber)
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

            contacts.AddLast(c);
            Console.WriteLine("Contact added.");
        }

        public void DeleteContact()
        {
            Console.Write("Enter Phone Number to Delete: ");
            string number = Console.ReadLine();

            var current = contacts.First;

            while (current != null)
            {
                if (current.Value.PhoneNumber == number)
                {
                    contacts.Remove(current);
                    Console.WriteLine("Contact deleted.");
                    return;
                }
                current = current.Next;
            }

            Console.WriteLine("Contact not found.");
        }

        public void EditContact()
        {
            Console.Write("Enter Phone Number to Edit: ");
            string phnNumber = Console.ReadLine();

            foreach (var person in contacts)
            {
                if (person.PhoneNumber == phnNumber)
                {
                    Console.Write("New Name: ");
                    person.FirstName = Console.ReadLine();

                    Console.Write("New City: ");
                    person.City = Console.ReadLine();

                    Console.WriteLine("Contact updated.");
                    return;
                }
            }

            Console.WriteLine("Contact not found.");
        }

        public void Sort()
        {
            if (contacts.Count <= 1)
                return;

            bool swapped;
            do
            {
                swapped = false;
                var node = contacts.First;

                while (node.Next != null)
                {
                    if (node.Value.FirstName
                        .CompareTo(node.Next.Value.FirstName) > 0)
                    {
                        ContactPerson temp = node.Value;
                        node.Value = node.Next.Value;
                        node.Next.Value = temp;
                        swapped = true;
                    }
                    node = node.Next;
                }
            } while (swapped);

            Console.WriteLine("Contacts sorted.");
        }

        public void DisplayContacts()
        {
            foreach (var person in contacts)
            {
                Console.WriteLine(
                    person.FirstName + " " +
                    person.LastName + ", " +
                    person.City + ", " +
                    person.PhoneNumber
                );
            }
        }
    }
}
