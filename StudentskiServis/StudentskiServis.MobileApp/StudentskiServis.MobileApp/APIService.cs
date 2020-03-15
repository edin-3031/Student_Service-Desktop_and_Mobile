using Flurl.Http;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiServis.MobileApp
{
    public class APIService
    {

#if DEBUG
        private string _apiURL = "http://localhost:52043/api";
#endif
#if RELEASE
        private string _apiURL = "http://localhost:52043/api";
#endif
        private string _route = null;
        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{_apiURL}/{_route}";

            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }

            var result = await url.GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_apiURL}/{_route}/{id}";

            return await url.GetJsonAsync<T>();
        }

        public async Task<dynamic> Check_Username(string check)
        {
            var url = $"{_apiURL}/{_route}/{check}";

            return await url.GetJsonAsync<dynamic>();
        }


        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{_apiURL}/{_route}/{id},{request}";

            return await url.PutJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<dynamic> Delete(int? _id)
        {
            var url = $"{_apiURL}/{_route}/{_id}";

            return await url.DeleteAsync().ReceiveJson<dynamic>();
        }

        public async Task<dynamic> Insert(object novi)
        {
            var url = $"{_apiURL}/{_route}/{novi}";

            return await url.PostJsonAsync(novi).ReceiveJson<dynamic>();
        }

        public async Task<dynamic> Auth(object username, object pass, object ulogaId)
        {
            var url = $"{_apiURL}/{_route}/{username},{pass},{ulogaId}";

            return await url.GetJsonAsync<dynamic>();
        }
    }
}
