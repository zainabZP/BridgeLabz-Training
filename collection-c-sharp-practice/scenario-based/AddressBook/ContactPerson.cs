using System;

namespace AddressBook
{
    internal class ContactPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        // UC7 – Duplicate check by Name
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is ContactPerson))
                return false;

            ContactPerson other = (ContactPerson)obj;
            return FirstName.Equals(other.FirstName, StringComparison.OrdinalIgnoreCase)
                && LastName.Equals(other.LastName, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return (FirstName + LastName).ToLower().GetHashCode();
        }

        // UC10 – ToString for display
        public override string ToString()
        {
            return $"{FirstName} {LastName}, {City}, {State}, {PhoneNumber}";
        }
    }
}
