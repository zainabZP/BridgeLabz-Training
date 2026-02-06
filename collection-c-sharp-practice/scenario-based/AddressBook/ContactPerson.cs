using System;

namespace AddressBook
{
    internal class ContactPerson
    {
        public string FirstName = "";
        public string LastName = "";
        public string Address = "";
        public string City = "";
        public string State = "";
        public string Zip = "";
        public string PhoneNumber = "";
        public string Email = "";

        // UC7 – Duplicate check
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

        // UC10 – Display
        public override string ToString()
        {
            return FirstName + " " + LastName + ", " +
                   City + ", " + State + ", " + PhoneNumber;
        }
    }
}
