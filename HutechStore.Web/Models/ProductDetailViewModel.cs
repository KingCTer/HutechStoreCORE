using HutechStore.ViewModels.Catalog.Categories;
using HutechStore.ViewModels.Catalog.ProductImages;
using HutechStore.ViewModels.Catalog.Products;
using System.Collections.Generic;

namespace HutechStore.Web.Models
{
    public class ProductDetailViewModel
    {
        public CategoryVm Category { get; set; }

        public ProductVm Product { get; set; }

        public List<ProductVm> RelatedProducts { get; set; }

        public List<ProductImageViewModel> ProductImages { get; set; }
    }
}