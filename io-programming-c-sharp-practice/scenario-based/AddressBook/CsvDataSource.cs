using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class CsvDataSource : IDataSource
    {
        public async Task SaveAsync(List<ContactPerson> contacts)
        {
            CsvService service = new CsvService();
            service.Write(contacts);
            await Task.CompletedTask;
        }
    }
}
