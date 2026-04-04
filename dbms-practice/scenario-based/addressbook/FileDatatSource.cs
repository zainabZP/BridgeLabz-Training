using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class FileDataSource : IDataSource
    {
        public async Task SaveAsync(List<ContactPerson> contacts)
        {
            FileIOService service = new FileIOService();
            await service.WriteAsync(contacts);
        }
    }
}
