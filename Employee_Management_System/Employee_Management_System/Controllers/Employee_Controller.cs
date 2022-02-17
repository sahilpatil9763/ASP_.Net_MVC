using Employee_Management_System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management_System.Controllers
{
    public class Employee_Controller : Controller
    {
        private readonly EmployeeContext _context;
        public Employee_Controller(EmployeeContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var employees = await _context.Employees.ToListAsync();
            return View(employees); 
        }
    }
}
