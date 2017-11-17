﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpringBoot.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpringBoot.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private CarRepository CarRepository;

        public HomeController(CarRepository carRepository)
        {
            CarRepository = carRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
