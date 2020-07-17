using EmployeeManagementSys.Models;
using EmployeeManagementSys.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSys.Controllers
{
   
    public class HomeController : Controller
    {
        private IEmployeeService _service;

        public HomeController(IEmployeeService service)
        {
            _service = service;
        }

     
        public ViewResult Index()
        {
            var result = _service.GetAllEmployees();
            ViewBag.Title = "Employee Details Page!";
            return View(result);
        }


      
        public ViewResult Details(int? id)
        {
            HomeDetailViewModel model = new HomeDetailViewModel()
            {
                Employee = _service.GetEmployeeData(id??1),
                PageTitle = "Employee Details"
            };
           
            return View(model);
        }
       
    }

}
