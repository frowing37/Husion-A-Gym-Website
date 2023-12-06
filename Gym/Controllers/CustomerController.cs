using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gym_Entity.Concrete;
using Gym_Business.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Gym.Controllers
{
    public class CustomerController : BaseController
    {
        public TargetManager _targetManager;

        public CustomerController(UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            RoleManager<AppRole> roleManager,
            TargetManager targetManager) : base(userManager, signInManager, roleManager)
        {
            _targetManager = targetManager;
        }
        

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

        [HttpGet]
        public IActionResult FirstInputs()
        {
            List<SelectListItem> targets = (from x in _targetManager.SGetList()
                                                      select new SelectListItem
                                                      {
                                                          Text = x.TargetName,
                                                          Value = x.ID.ToString()
                                                      }).ToList();

            ViewBag.Targets = targets;


            return View();
        }
    }
}

