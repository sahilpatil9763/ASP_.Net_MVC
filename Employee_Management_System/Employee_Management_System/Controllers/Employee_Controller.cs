using Employee_Management_System.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management_System.Controllers
{
    public class Employee_Controller : Controller
    {
        private readonly EmployeeContext context;
        public Employee_Controller(EmployeeContext context)
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
