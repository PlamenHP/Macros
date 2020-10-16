using System.Collections;
using Macros.Domain.Food.Factories.Menu;
using Macros.Domain.Food.Models.Menu;
using Microsoft.AspNetCore.Mvc;

namespace Macros.Web.Features
{
    [ApiController]
    [Route("[controller]")]
    public class MenuController : ControllerBase
    {
        //private static readonly FoodList foodList = new FoodList();

        [HttpGet]
        public FoodList Get() => new FoodListFactory().WithCreator("Foo").Build();
    }
}
