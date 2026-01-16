using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    internal interface IAdressBookOperations
    {
        void Contact();
        void EditContact();
        void DeleteContact();
        void DisplayContacts();
        void Sort();
    }
}
