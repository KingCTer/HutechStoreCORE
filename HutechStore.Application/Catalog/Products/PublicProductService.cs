using HutechStore.Application.Catalog.Products.Dtos;
using HutechStore.Application.Dtos;
using HutechStore.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutechStore.Application.Catalog.Products
{
    public class PublicProductService : IPublicProductService
    {
        

        public PagedViewModel<ProductViewModel> GetAllByCategoryId(int categoryId, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
