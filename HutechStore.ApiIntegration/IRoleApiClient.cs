using HutechStore.ViewModels.Common;
using HutechStore.ViewModels.System.Roles;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HutechStore.ApiIntegration
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RoleVm>>> GetAll();
    }
}