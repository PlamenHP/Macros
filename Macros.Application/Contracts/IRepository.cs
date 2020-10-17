using System.Threading;
using System.Threading.Tasks;
using Macros.Domain.Common;

namespace Macros.Application.Contracts
{
    public interface IRepository<in TEntity>
        where TEntity : IAggregateRoot
    {
        Task Save(TEntity entity, CancellationToken cancellationToken = default);
    }
}
