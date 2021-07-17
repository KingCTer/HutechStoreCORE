using HutechStore.ApiIntegration;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Threading.Tasks;

namespace HutechStore.Web.Controllers.Components
{
    public class AsideViewComponent : ViewComponent
    {
        private readonly ICategoryApiClient _categoryApiClient;

        public AsideViewComponent(ICategoryApiClient categoryApiClient)
        {
            _categoryApiClient = categoryApiClient;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var culture = CultureInfo.CurrentCulture.Name;

            var items = await _categoryApiClient.GetAll(culture);

            ViewBag.CurrentCulture = culture;
            return View(items);
        }
    }
}