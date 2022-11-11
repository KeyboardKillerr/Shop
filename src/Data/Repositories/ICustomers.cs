using System;
using System.Collections.Generic;
using System.Text;
using Data.Entities;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface ICustomers:IReposBase<Customer>
    {
        Task<bool> SendTokenAsync(Guid id);
    }
}
