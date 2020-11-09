using Macros.Domain.Common.Models;

namespace Macros.Domain.Common.Factories
{
    public interface IFactory<out TEntity>
        where TEntity : IAggregateRoot
    {
        TEntity Build();
    }
}
