using HutechStore.Application.Catalog.Products.Dtos;
using HutechStore.Application.Dtos;
using HutechStore.Data.EF;
using HutechStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutechStore.Application.Catalog.Products
{
    public class ManageProductService : IManageProductService
    {
        private readonly HutechStoreDbContext _context;

        public ManageProductService(HutechStoreDbContext context)
        {
            _context = context;
            
        }

        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price,
            };
            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<PagedViewModel<ProductViewModel>> GetAllPaging(string keyword, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(ProductUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
