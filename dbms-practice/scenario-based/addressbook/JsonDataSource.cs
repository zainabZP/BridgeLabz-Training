using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class JsonDataSource : IDataSource
    {
        public async Task SaveAsync(List<ContactPerson> contacts)
        {
            JsonService service = new JsonService();
            service.Write(contacts);
            await Task.CompletedTask;
        }
    }
}
