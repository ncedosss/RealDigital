using ACMERecognition.ManagementService.Common.Exceptions;
using ACMERecognition.ManagementService.Common.Exceptions.Base;
using ACMERecognition.ManagementService.DTO.Data;
using ACMERecognition.ManagementService.DTO.Mapping;
using Nancy;
using Nancy.Responses.Negotiation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMERecognition.ManagementService.Common.Logic
{
    public class ErrorEvents : Error
    {
        public dynamic Set(NancyContext nancyContext, Negotiator negotiate, Exception exception)
        {
            APIException apiException;

            if (exception is BadRequestError)
            {
                apiException = (BadRequestError)exception;
            }
            else if (exception is GlobalError)
            {
                apiException = (GlobalError)exception;
            }
            else
            {
                apiException = new APIException();
                apiException.ExceptionMapping = new ExceptionMapping();
                apiException.ExceptionMapping.ErrorCode = System.Net.HttpStatusCode.BadRequest;
                apiException.ExceptionMapping.Error.ErrorName = "Unexpected Error";
                apiException.ExceptionMapping.Error.ErrorMessage = "Sorry, something went wrong!<br>Our technical team will resolve the issue as soon as possible.  Please try again later.";
            }

            return negotiate.WithModel(
                    new ExceptionMapping()
                    {
                        ErrorCode = apiException.ExceptionMapping.ErrorCode,
                        Error = {
                            ErrorName = apiException.ExceptionMapping.Error.ErrorName,
                            ErrorMessage = apiException.ExceptionMapping.Error.ErrorMessage
                        }
                    }
                    ).WithStatusCode((HttpStatusCode)apiException.ExceptionMapping.ErrorCode);
        }
    }
}
