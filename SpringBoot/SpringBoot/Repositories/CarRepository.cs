using System;
using System.Collections.Generic;
using System.Linq;
using SpringBoot.Entities;
using SpringBoot.Models;

namespace SpringBoot.Repositories
{
    public class CarRepository
    {
        CarContext CarContext;

        public CarRepository (CarContext carContext)
        {
            CarContext = carContext;
        }

        public List<Car>GetList()
        {
            return CarContext.Cars.ToList();
        }

    }
}
