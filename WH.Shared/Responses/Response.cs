using WH.Shared.Enum;

namespace WH.Shared.Responses
{
    public class Response<T>
    {
        public ResultType Result { get; set; }
        public T? Data { get; set; }

        public Response(T data)
        {
            Data = data;
            Result = ResultType.SUCCESS;
        }
        public Response()
        {
            Result = ResultType.FAILURE;
        }
        public Response(ResultType type)
        {
            Result = type;
        }
    }
}