using HutechStore.ViewModels.Catalog.Products;
using HutechStore.ViewModels.Common;
using System.Threading.Tasks;

namespace HutechStore.Admin.Services
{
    public interface IProductApiClient
    {
        Task<PagedResult<ProductVm>> GetPagings(GetManageProductPagingRequest request);

        Task<bool> CreateProduct(ProductCreateRequest request);
    }
}