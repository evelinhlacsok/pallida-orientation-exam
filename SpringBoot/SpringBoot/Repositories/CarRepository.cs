﻿using System.Collections.Generic;
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
            return CarContext.CarPlates.ToList();
        }

        public List<Car> GetSearchedCars(string plate)
        {
            return CarContext.CarPlates.Where(x => x.Plate.Contains(plate)).ToList();
        }

        public List<Car>PoliceCars()
        {
            return CarContext.CarPlates.Where(x => x.Plate.StartsWith("RB")).ToList();        
        }

        public List<Car>DiplomatCars()
        {
            return CarContext.CarPlates.Where(x => x.Plate.StartsWith("DT")).ToList();
        }

        //public List<Car>SameBrand()
        //{
        //    return CarContext.Cars.Where(x => x.Brand).ToList();
        //}
    }
}
