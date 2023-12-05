using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gym_Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Gym.Controllers
{
    public class BaseController : Controller
    {
        public UserManager<AppUser> _userManager;
        public SignInManager<AppUser> _signInManager;
        public RoleManager<AppRole> _roleManager;

        public BaseController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
    }
}

