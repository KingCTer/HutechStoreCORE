using HutechStore.ApiIntegration;
using HutechStore.Utilities.Constants;
using HutechStore.ViewModels.Catalog.Products;
using HutechStore.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace HutechStore.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly ICategoryApiClient _categoryApiClient;
        private readonly IConfiguration _configuration;

        public ProductController(
            IProductApiClient productApiClient, 
            ICategoryApiClient categoryApiClient,
            IConfiguration configuration)
        {
            _productApiClient = productApiClient;
            _categoryApiClient = categoryApiClient;
            _configuration = configuration;
        }
        public async Task<IActionResult> Detail(int id, string culture)
        {
            var product = await _productApiClient.GetById(id, culture);
            return View(new ProductDetailViewModel()
            {
                Product = product,
                Category = await _categoryApiClient.GetById(culture, id)
            });
        }

        public async Task<IActionResult> Category(int id, string culture, int pageIndex = 1)
        {
            var products = await _productApiClient.GetPagings(new GetManageProductPagingRequest()
            {
                CategoryId = id,
                PageIndex = pageIndex,
                LanguageId = culture,
                PageSize = 12
            });

            ViewBag.BaseAddress = _configuration[SystemConstants.AppSettings.BaseAddress];
            ViewBag.CurrentCulture = CultureInfo.CurrentCulture.Name;
            return View(new ProductCategoryViewModel()
            {
                Category = await _categoryApiClient.GetById(culture, id),
                Products = products
            }); 
        }
    }
}
