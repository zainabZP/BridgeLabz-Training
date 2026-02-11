using System.Collections.Generic;

namespace AddressBook
{
    internal interface IAddressBookOperations
    {
        void AddContact();
        void EditContact();
        void DeleteContact();
        void DisplayContacts();
        void SortByName();
        List<ContactPerson> GetContacts();
    }
}

