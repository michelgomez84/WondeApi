using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace WondeApiServices.Helpers
{
    /// <summary>
    /// Generic Class to manage httpclient connections for REST API 
    /// </summary>
    public class ApiConnection : IDisposable
    {
        public ApiConnection(string baseUrl = null)
        {
            Url = baseUrl;
        }

        private HttpClient _Client = null;
        public HttpClient Client
        {
            get
            {
                try
                {
                    if (_Client == null)
                    {
                        _Client = new HttpClient(
                        new HttpClientHandler
                        {
                            UseCookies = true,
                            CookieContainer = new CookieContainer()
                        });
                        _Client.BaseAddress = new Uri(Url);
                        _Client.DefaultRequestHeaders.Accept.Clear();
                        _Client.DefaultRequestHeaders.Clear();
                        _Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        //_Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));
                        //_Client.DefaultRequestHeaders.Add("Basic", "ZmRvdEQ2OjQ1NE1lV2JvakpN");
                    }
                }
                catch { }
                return _Client;
            }
            set { _Client = value; }
        }

        public string Url { get; set; }

        public void Dispose()
        {
            try { Client.Dispose(); Client = null; }
            catch { }
        }
    }
}