using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSys.Models
{
    public class EmployeeImplementation : IEmployeeService
    {
        private List<Employee> _employees;

        public EmployeeImplementation()
        {
            _employees = new List<Employee>()
            {
               new Employee(){Name="Precious K Wonkulah", Department="Finance", Email="wonkulahp@yahoo.com", Id=1},
               new Employee(){Name="Bestie James", Department="Accountant", Email="bestiejames@gmail.com",Id=2},
               new Employee(){Name="Alex Smith", Department="IT", Email="alexsmith@outlook.com",Id=3},
               new Employee(){Name="Dad S Wonkulah Jr", Department="IT", Email="dadwonkulahjr96@gmail.com",Id=4},
            };

        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            foreach (var item in _employees)
            {
                yield return item;
            }
        }

        public Employee GetEmployeeData(int id)
        {
            return _employees.FirstOrDefault(emp => emp.Id == id);
        }

      
        
    }
}
