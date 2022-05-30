using WH.Shared.Entities;
using WH.Shared.Responses;

namespace WH.Proxy.Subjects.Interfaces
{
    public interface IStationProxy
    {
        public Response<int>? Add(Station s);

        public Response<Station>? Get(int id);

        public Response<List<Station>>? GetAll();

        public Response<bool>? Delete(Station s);

        public Response<bool>? Update(Station s);

        public Response<bool>? UpdateColumns(List<int> columnsIndex);
    }
}
