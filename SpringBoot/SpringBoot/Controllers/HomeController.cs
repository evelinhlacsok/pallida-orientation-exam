using System;
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

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/search")]
        [HttpGet]
        public IActionResult ListCars()
        {
            return View(CarRepository.GetList());
        }

        [Route("/search/police")]
        [HttpGet]
        public IActionResult PoliceCars(string plate)
        {
            CarRepository.PoliceCars();
            return RedirectToAction("list");
        }

        [Route("/search/diplomats")]
        [HttpGet]
        public IActionResult DiplomatCars()
        {
            CarRepository.DiplomatCars();
            return RedirectToAction("list");
        }

        //[Route("/search/{brand}")]
        //[HttpGet]
        //public IActionResult BrandSearch()
        //{
           
        //}
    }
}
