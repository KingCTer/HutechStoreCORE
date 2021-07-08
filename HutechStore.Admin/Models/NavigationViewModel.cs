using HutechStore.ViewModels.System.Languages;
using System.Collections.Generic;

namespace HutechStore.Admin.Models
{
    public class NavigationViewModel
    {
        public List<LanguageVm> Languages { get; set; }
        public string CurrentLanguageId { get; set; }
    }
}