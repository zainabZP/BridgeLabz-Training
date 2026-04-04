using System.Collections.Generic;
using System.IO;

namespace AddressBook
{
    internal class CsvService
    {
        private string path = "addressbook.csv";

        public void Write(List<ContactPerson> contacts)
        {
            using StreamWriter writer = new StreamWriter(path);

            foreach (var p in contacts)
                writer.WriteLine($"{p.FirstName},{p.LastName},{p.City},{p.State},{p.Zip},{p.PhoneNumber},{p.Email}");
        }
    }
}
