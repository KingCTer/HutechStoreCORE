using HutechStore.ViewModels.System.Roles;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HutechStore.Application.System.Roles
{
    public interface IRoleService
    {
        Task<List<RoleVm>> GetAll();
    }
}