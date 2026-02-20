using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class FileIOService
    {
        private string path = "addressbook.txt";

        public async Task WriteAsync(List<ContactPerson> contacts)
        {
            using StreamWriter writer = new StreamWriter(path);

            foreach (var p in contacts)
                await writer.WriteLineAsync(p.ToString());
        }
    }
}
