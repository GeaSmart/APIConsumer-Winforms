using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsumidorAPI.ApiHelper
{
    public class Consumer
    {
        private static HttpMethod CreateHttpMethod(methodHttp method)
        {
            switch (method)
            {
                case methodHttp.GET:
                    return HttpMethod.Get;
                case methodHttp.POST:
                    return HttpMethod.Post;
                case methodHttp.PUT:
                    return HttpMethod.Put;
                case methodHttp.DELETE:
                    return HttpMethod.Delete;
                default:
                    throw new NotImplementedException("Not implemented http method");
            }
        }

        public static async Task<Reply> Execute<T>(string url, methodHttp method, T objectRequest)
        {
            Reply oReply = new Reply();
            try
            {
                using (HttpClient client = new HttpClient())
                {

                    var myContent = JsonConvert.SerializeObject(objectRequest);
                    var bytecontent = new ByteArrayContent(Encoding.UTF8.GetBytes(myContent));
                    bytecontent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                    var request = new HttpRequestMessage(CreateHttpMethod(method), url)
                    {
                        Content = (method != methodHttp.GET) ? method != methodHttp.DELETE ? bytecontent : null : null
                    };

                    using (HttpResponseMessage res = await client.SendAsync(request))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();
                            if (data != null)
                                oReply.Data = JsonConvert.DeserializeObject<T>(data);

                            oReply.StatusCode = res.StatusCode.ToString();
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                oReply.StatusCode = "ServerError";
                var response = (HttpWebResponse)ex.Response;
                if (response != null)
                    oReply.StatusCode = response.StatusCode.ToString();
            }
            catch (Exception ex)
            {
                oReply.StatusCode = "AppError";
            }
            return oReply;
        }
    }
}
