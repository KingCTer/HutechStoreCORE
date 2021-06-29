using HutechStore.ViewModels.Common;
using HutechStore.ViewModels.System.Users;
using System.Threading.Tasks;

namespace HutechStore.Application.System.Users
{
    public interface IUserService
    {
        Task<string> Authencate(LoginRequest request);

        Task<bool> Register(RegisterRequest request);

        Task<PagedResult<UserVm>> GetUsersPaging(GetUserPagingRequest request);
    }
}