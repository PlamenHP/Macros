using Macros.Domain.Common;

namespace Macros.Domian.Common
{
    public interface IFactory<out TEntity>
        where TEntity : IAggregateRoot
    {
        TEntity Build();
    }
}
