using System.Threading.Tasks;
using Macros.Application.Common;
using Macros.Application.Identity.Commands;
using Macros.Application.Identity.Commands.ChangePassword;
using Macros.Application.Identity.Commands.LoginUser;

namespace Macros.Application.Identity
{
    public interface IIdentity
    {
        Task<Result<IUser>> Register(UserInputModel userInput);

        Task<Result<LoginSuccessModel>> Login(UserInputModel userInput);

        Task<Result> ChangePassword(ChangePasswordInputModel changePasswordInput);
    }
}