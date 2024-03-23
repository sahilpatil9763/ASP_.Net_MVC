using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Adding_Controller.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public string EmployeeProfile(int id)
        {
            string profile = string.Empty;

            if (id == 1)
            {
                profile = "Employee 1 profile";
            }

            else if (id == 2)
            {
                profile = "Employee 2 profile";
            }

            else
            {
                profile = "No Record Found";
            }

            return profile;
        }

        public string Address (int id, int code)
        {
            return "id = " + id + " dept = " + code;
        }
    }
}