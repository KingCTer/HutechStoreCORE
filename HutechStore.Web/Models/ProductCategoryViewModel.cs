using HutechStore.ViewModels.Catalog.Categories;
using HutechStore.ViewModels.Catalog.Products;
using HutechStore.ViewModels.Common;

namespace HutechStore.Web.Models
{
    public class ProductCategoryViewModel
    {
        public CategoryVm Category { get; set; }

        public PagedResult<ProductVm> Products { get; set; }
    }
}