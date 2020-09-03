using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMERecognition.ManagementService.DTO.Data
{
    public class Error
    {
        [JsonProperty(PropertyName = "error_name")]
        public string ErrorName { get; set; }

        [JsonProperty(PropertyName = "error_message")]
        public string ErrorMessage { get; set; }
    }
}
