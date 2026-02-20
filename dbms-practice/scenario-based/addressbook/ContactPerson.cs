

using System;

namespace AddressBook
{
    internal class ContactPerson : IComparable<ContactPerson>
    {
        public string FirstName = "";
        public string LastName = "";
        public string Address = "";
        public string City = "";
        public string State = "";
        public string Zip = "";
        public string PhoneNumber = "";
        public string Email = "";

        public int CompareTo(ContactPerson? other)
        {
            if (other == null) return 1;
            return FirstName.CompareTo(other.FirstName);
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {City}, {State}, {Zip}, {PhoneNumber}, {Email}";
        }
    }
}
