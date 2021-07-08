using HutechStore.ViewModels.Common;
using HutechStore.ViewModels.System.Languages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HutechStore.Application.System.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}