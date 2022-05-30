using WH.Proxy.Subjects.Interfaces;
using WH.Shared.Entities;
using WH.Shared.Responses;

namespace WH.Proxy.Subjects
{
    public class CommonProxy : Service, ICommonProxy
    {
        private readonly string _url;
        public CommonProxy(string baseUrl) : base(baseUrl)
        {
            _url = "/api/station";
        }

        public Response<List<ComboExample>>? GetAllComboList()
        {
            return Get<Response<List<ComboExample>>>($"{_url}/combo");
        }
    }
}