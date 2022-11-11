using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface IReposBase<TTable> where TTable:class
    {
        IQueryable<TTable> Items { get; }
        Task<TTable> GetItemByIdAsync(Guid id);
        Task<int> UpdateAsync(TTable table);
        Task<int> DeleteAsync(Guid id);

    }
}
