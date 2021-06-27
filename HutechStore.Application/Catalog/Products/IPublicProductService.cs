using HutechStore.Application.Catalog.Products.Dtos;
using HutechStore.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutechStore.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PagedViewModel<ProductViewModel> GetAllByCategoryId(int categoryId, int pageIndex, int pageSize);
    }
}
