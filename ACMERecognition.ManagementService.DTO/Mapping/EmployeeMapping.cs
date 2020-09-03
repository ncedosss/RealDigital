using ACMERecognition.ManagementService.DTO.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMERecognition.ManagementService.DTO.Mapping
{
    public class EmployeeMapping
    {
        [JsonProperty(PropertyName = "Employee")]
        public Employee Employee { get; set; }
    }
}
