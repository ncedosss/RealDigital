using ACMERecognition.ManagementService.Common.Interface;
using ACMERecognition.ManagementService.DTO.Data;
using ACMERecognition.ManagementService.DTO.Mapping;
using ACMERecognition.ManagementService.Logic.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMERecognition.ManagementService.Common.Logic
{
    public class EmployeeEvents : IEmployeeEvents
    {
        public EmployeeMapping GetEmployee()
        {
            EmployeeMapping employees = null;

            employees = Manager.GetEmployee();

            return employees;
        }
    }
}
