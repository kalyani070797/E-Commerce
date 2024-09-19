using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model
{
    public class CommonApi
    {
        public HttpStatusCode StatusCode { get; set; }
        public dynamic? Data {  get; set; }
        public string Message { get; set; }
    }
}
