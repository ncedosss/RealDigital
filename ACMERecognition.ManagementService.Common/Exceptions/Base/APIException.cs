using ACMERecognition.ManagementService.DTO.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMERecognition.ManagementService.Common.Exceptions.Base
{
    public class APIException : Exception
    {
        public APIException() : base()
        {
            ExceptionMapping = new ExceptionMapping();
        }

        public APIException(string message) : base(message)
        {
            ExceptionMapping = new ExceptionMapping();
        }

        public ExceptionMapping ExceptionMapping { get; set; }
    }
}
