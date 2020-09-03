using ACMERecognition.ManagementService.Common.Exceptions.Base;
using System.Net;

namespace ACMERecognition.ManagementService.Common.Exceptions
{
    public class GlobalError : APIException
    {
        public GlobalError() : base()
        {
            ExceptionMapping.ErrorCode = HttpStatusCode.BadRequest;
            ExceptionMapping.Error.ErrorName = "Internal Error";
            ExceptionMapping.Error.ErrorMessage = "A system error has occurred while processing the client request.";
        }
    }
}
