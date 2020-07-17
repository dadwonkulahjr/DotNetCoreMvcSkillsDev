using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSys.Models
{
    public interface IEmployeeService
    {
        Employee GetEmployeeData(int id);
        IEnumerable<Employee> GetAllEmployees();
      
    }
}
