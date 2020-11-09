using Macros.Application.Identity;
using Microsoft.AspNetCore.Identity;

namespace Macros.Infrastructure.Persistance.Identity
{
    public class User : IdentityUser, IUser
    {
        internal User(string email)
            : base(email)
            => this.Email = email;
    }
}