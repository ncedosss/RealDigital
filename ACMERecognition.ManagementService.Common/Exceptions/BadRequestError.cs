using ACMERecognition.ManagementService.Common.Exceptions.Base;
using System.Net;

namespace ACMERecognition.ManagementService.Common.Exceptions
{
    public class BadRequestError : APIException
    {
        public BadRequestError(string message) : base(message)
        {
            ExceptionMapping.ErrorCode = HttpStatusCode.BadRequest;
            ExceptionMapping.Error.ErrorName = "Bad Request";
            ExceptionMapping.Error.ErrorMessage = message;
        }
    }
}
