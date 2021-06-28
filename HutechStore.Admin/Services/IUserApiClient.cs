using HutechStore.ViewModels.System.Users;
using System.Threading.Tasks;

namespace HutechStore.Admin.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);
    }
}