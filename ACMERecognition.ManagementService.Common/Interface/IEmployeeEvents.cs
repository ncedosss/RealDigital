using ACMERecognition.ManagementService.DTO.Data;
using ACMERecognition.ManagementService.DTO.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMERecognition.ManagementService.Common.Interface
{
    public interface IEmployeeEvents
    {
        EmployeeMapping GetEmployee();
    }
}
