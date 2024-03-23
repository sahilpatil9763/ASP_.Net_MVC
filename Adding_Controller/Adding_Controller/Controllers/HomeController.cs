using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Adding_Controller.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello from Sahil";
        }

        public string Name()
        {
            return " My full name is Sahil Mahadev Patil";
        }
    }
}