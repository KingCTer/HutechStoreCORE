using HutechStore.ViewModels.Common;
using HutechStore.ViewModels.System.Users;
using System.Threading.Tasks;

namespace HutechStore.Admin.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);

        Task<PagedResult<UserVm>> GetUsersPagings(GetUserPagingRequest request);
    }
}