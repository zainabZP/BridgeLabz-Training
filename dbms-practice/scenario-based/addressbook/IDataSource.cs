using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddressBook
{
    internal interface IDataSource
    {
        Task SaveAsync(List<ContactPerson> contacts);
    }
}
