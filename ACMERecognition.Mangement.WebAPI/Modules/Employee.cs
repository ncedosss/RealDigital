using ACMERecognition.ManagementService.Common.Logic;
using ACMERecognition.ManagementService.DTO.Mapping;
using ACMERecognition.Mangement.WebAPI.Client;
using Nancy;
using Newtonsoft.Json;
using System;

namespace ACMERecognition.Mangement.WebAPI.Modules
{
    public class Employee : NancyModule
    {
        public Employee() : base("/api/employee")
        {
            EmployeeRequest request;
            EmployeeMapping employeeMapping;
            
            Get["/employee"] = parameters =>
            {
                try
                {
                    employeeMapping = new EmployeeMapping();
                    employeeMapping.Employee = new ManagementService.DTO.Data.Employee { };

                    request = new EmployeeRequest(new EmployeeEvents(), employeeMapping);
                    employeeMapping = request.GetEmployee();

                    return Response.AsJson(employeeMapping, HttpStatusCode.OK);
                }
                catch (Exception ex)
                {
                    return new ErrorEvents().Set(this.Context, Negotiate, ex);
                }
            };
        }
    }
}