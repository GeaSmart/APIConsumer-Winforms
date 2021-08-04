using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumidorAPI.ApiHelper
{
    public class Reply
    {
        public string StatusCode { get; set; }
        public object Data { get; set; }
    }

    public enum methodHttp
    {
        GET,
        POST,
        PUT,
        DELETE
    }
}
