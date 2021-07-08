using HutechStore.ViewModels.Common;
using HutechStore.ViewModels.System.Languages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HutechStore.Admin.Services
{
    public interface ILanguageApiClient
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}