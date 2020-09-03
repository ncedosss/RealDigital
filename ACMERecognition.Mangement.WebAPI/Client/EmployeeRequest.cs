using ACMERecognition.ManagementService.Common.Interface;
using ACMERecognition.ManagementService.DTO.Data;
using ACMERecognition.ManagementService.DTO.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ACMERecognition.Mangement.WebAPI.Client
{
    public class EmployeeRequest
    {
        private readonly IEmployeeEvents _service;
        private readonly EmployeeMapping _employeeMapping;

        public EmployeeRequest(IEmployeeEvents service, EmployeeMapping employeeMapping)
        {
            this._service = service;
            this._employeeMapping = employeeMapping;
        }
        public EmployeeMapping GetEmployee()
        {
            return this._service.GetEmployee();
        }
    }
}