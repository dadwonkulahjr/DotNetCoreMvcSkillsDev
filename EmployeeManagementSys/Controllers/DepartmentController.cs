using EmployeeManagementSys.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSys.Controllers
{
    public class DepartmentController : Controller
    {
        private IEmployeeService _empService;

        public DepartmentController(IEmployeeService employeeService)
        {
            _empService = employeeService;
        }
        public string Greetings()
        {
            return "Good morning the date and time check is " + DateTime.Now.ToUniversalTime();
        }

        public string GetResult()
        {
            return "Hi Welcome, " + _empService.GetAllEmployees().First().Name;
        }
    }
}
