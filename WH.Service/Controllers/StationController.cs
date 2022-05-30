using Microsoft.AspNetCore.Mvc;
using WH.Logic;
using WH.Shared.Entities;
using WH.Shared.Responses;

namespace WH.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationController : ControllerBase
    {
        private StationLogic _logic;

        public StationController()
        {
            _logic = new StationLogic();
        }

        [HttpGet("{id}")]
        public Response<Station?> Get([FromRoute] int id)
        {
            var data = _logic.Get(id);
            if(data == null) { return new Response<Station?>(Shared.Enum.ResultType.NOT_FOUND); }
            var response = new Response<Station?>(data);

            return response;
        }

        [HttpGet]
        public Response<List<Station>> GetAll()
        {
            var data = _logic.GetAll();
            if (data == null) { return new Response<List<Station>>(Shared.Enum.ResultType.FAILURE); }
            var response = new Response<List<Station>>(data);

            return response;
        }

        [HttpPost]
        public Response<int> Add([FromBody]Station station)
        {
            var data = _logic.Add(station);
            if (data == 0) { return new Response<int>(Shared.Enum.ResultType.FAILURE); }
            var response = new Response<int>(data);

            return response;
        }

        [HttpPut]
        public Response<bool>? Update([FromBody] Station station)
        {
            var data = _logic.Update(station);
            if (!data) { return new Response<bool>(Shared.Enum.ResultType.FAILURE); }
            var response = new Response<bool>(Shared.Enum.ResultType.SUCCESS);

            return response;
        }

        [HttpDelete]
        public Response<bool>? Delete([FromBody] Station station)
        {
            var data = _logic.Delete(station);
            if (!data) { return new Response<bool>(Shared.Enum.ResultType.FAILURE); }
            var response = new Response<bool>(Shared.Enum.ResultType.SUCCESS);

            return response;
        }

        [HttpGet("combo")]
        public Response<List<ComboExample>> GetAllComboList()
        {
            var data = _logic.GetAllComboList();
            if (data == null) { return new Response<List<ComboExample>>(Shared.Enum.ResultType.FAILURE); }
            var response = new Response<List<ComboExample>>(data);

            return response;
        }

        [HttpPut("replace")]
        public Response<bool>? Update([FromBody] List<int> updateColumns)
        {
            var data = _logic.UpdateColumns(updateColumns);
            if (!data) { return new Response<bool>(Shared.Enum.ResultType.FAILURE); }
            var response = new Response<bool>(Shared.Enum.ResultType.SUCCESS);

            return response;
        }
    }
}
