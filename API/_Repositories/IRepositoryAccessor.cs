
using Microsoft.EntityFrameworkCore.Storage;

namespace API._Repositories
{
    public interface IRepositoryAccessor
    {

        Task<bool> Save();
        Task<IDbContextTransaction> BeginTransactionAsync();
        
    }
}