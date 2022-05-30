using WH.Shared.Entities;
using WH.Shared.Responses;

namespace WH.Proxy.Subjects.Interfaces
{
    public interface ICommonProxy
    {
        public Response<List<ComboExample>>? GetAllComboList();
    }
}
