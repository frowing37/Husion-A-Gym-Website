using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Gym.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Customers()
        {
            return View();
        }

        public IActionResult Antrenors()
        {
            return View();
        }

        public IActionResult AntrenorsDetail()
        {
            return View();
        }

        public IActionResult CustomersDetail()
        {
            return View();
        }

        public IActionResult NewAntrenor()
        {
            return View();
        }

        public IActionResult NewCustomer()
        {
            return View();
        }

        public IActionResult UpdateAntrenor()
        {
            return View();
        }

        public IActionResult UpdateCustomer()
        {
            return View();
        }
    }
}

