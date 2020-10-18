using System.Threading;
using System.Threading.Tasks;
using Macros.Application.Contracts;
using Macros.Domain.Food.Models.Diet;

namespace Macros.Application.Diet
{
    public interface IDietRepository : IRepository<ConsumedFoodList>
    {
        Task<ConsumedFoodList> AddNewDiet(string user, string listName = default!);
        Task<ConsumedFoodList> GetDietInfo(int id, CancellationToken cancellationToken = default!);


    }
}
