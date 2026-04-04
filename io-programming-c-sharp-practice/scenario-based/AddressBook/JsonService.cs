using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace AddressBook
{
    internal class JsonService
    {
        private string path = "addressbook.json";

        public void Write(List<ContactPerson> contacts)
        {
            var json = JsonSerializer.Serialize(contacts,
                new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(path, json);
        }
    }
}
