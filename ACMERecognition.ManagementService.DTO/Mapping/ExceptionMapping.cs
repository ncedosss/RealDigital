using ACMERecognition.ManagementService.DTO.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ACMERecognition.ManagementService.DTO.Mapping
{
    public class ExceptionMapping
    {
        [JsonProperty(PropertyName = "error_code")]
        public HttpStatusCode ErrorCode { get; set; }

        [JsonProperty(PropertyName = "error")]
        public Error Error { get; set; }

        public ExceptionMapping()
        {
            Error = new Error();
        }
    }
}
