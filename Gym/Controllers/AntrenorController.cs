using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Gym.Controllers
{
    public class AntrenorController : Controller
    {
        public IActionResult CustomersDetail()
        {
            return View();
        }

        public IActionResult CustomersList()
        {
            return View();
        }

        public IActionResult ExerciseLists()
        {
            return View();
        }

        public IActionResult Messages()
        {
            return View();
        }

        public IActionResult NutritionLists()
        {
            return View();
        }

        /*public IActionResult UpdateExerciseList()
        {
            return View();
        }

        public IActionResult ExerciseListDetail()
        {
            return View();
        }*/
    }
}

