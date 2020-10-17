using System.Collections;
using Macros.Domain.Food.Factories.Menu;
using Macros.Domain.Food.Models.Menu;
using Microsoft.AspNetCore.Mvc;

namespace Macros.Web.Features
{
    public class MenuController : ApiController
    {
        [HttpGet]
        public FoodList GetList() => null!;

        [HttpPost]
        public FoodList CreateList([FromBody] string name, string creator) => 
            new FoodListFactory().WithName(name).WithCreator(creator).Build();
    }
}
