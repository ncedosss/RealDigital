using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMERecognition.ManagementService.DTO.Data
{
    public class Employee
    {
        [JsonProperty(PropertyName = "id")]
        public int id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }

        [JsonProperty(PropertyName = "lastname")]
        public string lastname { get; set; }

        [JsonProperty(PropertyName = "dateOfBirth", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime dateOfBirth { get; set; }

        [JsonProperty(PropertyName = "employmentStartDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime employmentStartDate { get; set; }

        [JsonProperty(PropertyName = "employmentEndDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime employmentEndDate { get; set; }
    }
}
