﻿using Flurl.Http;
using Flurl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentskiServis.Models;
using System.Drawing;
using StudentskiServis.Models.Requests;

namespace StudentskiServis.WinUI
{
    public class APIService
    {
        private string _route = null;
        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {
            var url =$"{Properties.Settings.Default.APIUrl}/{_route}";

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
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            return await url.GetJsonAsync<T>();
        }

        public async Task<dynamic> Check_Username(string check)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{check}";

            return await url.GetJsonAsync<dynamic>();
        }


        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id},{request}";

            return await url.PutJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<dynamic> Delete(int? _id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{_id}";

            return await url.DeleteAsync().ReceiveJson<dynamic>();
        }

        public async Task<dynamic> Insert(object novi)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{novi}";

            return await url.PostJsonAsync(novi).ReceiveJson<dynamic>();
        }

        public async Task<dynamic> Auth(object username, object pass, object ulogaId)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{username},{pass},{ulogaId}";

            return await url.GetJsonAsync<dynamic>();
        }
    }
}