using WH.Proxy.Subjects.Interfaces;
using WH.Shared.Entities;
using WH.Shared.Responses;

namespace WH.Proxy.Subjects
{
    public class StationProxy : Service, IStationProxy
    {
        private readonly string _url;
        public StationProxy(string baseUrl) : base(baseUrl)
        {
            _url = "/api/station";
        }

        public Response<int>? Add(Station s)
        {
            return Post<Response<int>>(_url, s);
        }

        public Response<Station>? Get(int id)
        {
            return Get<Response<Station>>($"{_url}/{id}");
        }

        public Response<List<Station>>? GetAll()
        {
            return Get<Response<List<Station>>>(_url);
        }

        public Response<bool>? Delete(Station s)
        {
            return Delete<Response<bool>>(_url, s);
        }

        public Response<bool>? Update(Station s)
        {
            return Put<Response<bool>>(_url, s);
        }

        public Response<bool>? UpdateColumns(List<int> columnsIndex)
        {
            return Put<Response<bool>>($"{_url}/replace", columnsIndex);
        }
    }
}