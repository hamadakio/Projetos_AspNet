using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Proj2_CRUD.Models;

namespace Proj2_CRUD.Controllers
{
    public class CarsController : Controller
    {
        private readonly Context context;

        public CarsController(Context context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewCar()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewCar(Car car)
        {
            if (ModelState.IsValid)
            {
                context.Add(car);
                context.SaveChanges();
                RedirectToAction("Index" , "Cars");
            }

            return View(car);

        }
    }
}