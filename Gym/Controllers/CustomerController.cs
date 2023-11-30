using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Gym.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Exercises()
        {
            return View();
        }

        public IActionResult Nutrition()
        {
            return View();
        }

        public IActionResult Statics()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult FirstInputs()
        {
            return View();
        }
    }
}

