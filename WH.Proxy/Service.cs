using RestSharp;

namespace WH.Proxy
{
    public abstract class Service
    {
        protected readonly RestClient _client;

        public Service(string baseUrl)
        {
            this._client = new RestClient(baseUrl);
        }

        protected T? Post<T>(string url, object requestData)
        {
            var request = new RestRequest(url, Method.Post);
            request.AddJsonBody(requestData, "application/json");

            var response = _client.PostAsync<T>(request);

            return response.Result;
        }

        protected T? Put<T>(string url, object requestData)
        {
            var request = new RestRequest(url, Method.Put);
            request.AddJsonBody(requestData, "application/json");

            var response = _client.PutAsync<T>(request);

            return response.Result;
        }

        protected T? Delete<T>(string url, object requestData)
        {
            var request = new RestRequest(url, Method.Delete);
            request.AddJsonBody(requestData, "application/json");

            var response = _client.DeleteAsync<T>(request);

            return response.Result;
        }

        protected T? Get<T>(string url, Dictionary<string, string> parameters = null)
        {
            var request = new RestRequest(url, Method.Get);

            //if (parameters != null)
            //{
            //    foreach (var parameter in parameters)
            //    {
            //        request.AddParameter(parameter.Key, parameter.Value);
            //    }
            //}

            var response = _client.GetAsync<T>(request);

            return response.Result;
        }
    }
}
