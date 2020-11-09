using System.Threading;
using System.Threading.Tasks;
using Macros.Domain.Common.Models;

namespace Macros.Application.Common.Contracts
{
    public interface IRepository<in TEntity>
        where TEntity : IAggregateRoot
    {
        Task Save(TEntity entity, CancellationToken cancellationToken = default);
    }
}
