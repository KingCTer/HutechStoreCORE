using HutechStore.ViewModels.Common;
using HutechStore.ViewModels.System.Roles;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HutechStore.Admin.Services
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RoleVm>>> GetAll();
    }
}