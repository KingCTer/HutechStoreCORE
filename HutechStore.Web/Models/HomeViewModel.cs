using HutechStore.ViewModels.Catalog.Products;
using System.Collections.Generic;

namespace HutechStore.Web.Models
{
    public class HomeViewModel
    {
        public List<ProductVm> FeaturedProducts { get; set; }

        public List<ProductVm> LatestProducts { get; set; }
    }
}