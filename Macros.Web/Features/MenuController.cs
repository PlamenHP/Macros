using System.Collections;
using Macros.Domain.Menu.Factories;
using Macros.Domain.Menu.Models;
using Microsoft.AspNetCore.Mvc;

namespace Macros.Web.Features
{
    public class MenuController : ApiController
    {
        [HttpGet]
        public Food GetList() => null!;

        [HttpPost]
        public Food CreateList([FromBody] string name, string userId) => 
            new FoodFactory().WithName(name).FromUser(userId).Build();
    }
}
