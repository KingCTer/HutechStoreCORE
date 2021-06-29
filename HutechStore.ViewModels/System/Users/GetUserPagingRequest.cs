using HutechStore.ViewModels.Common;

namespace HutechStore.ViewModels.System.Users
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}