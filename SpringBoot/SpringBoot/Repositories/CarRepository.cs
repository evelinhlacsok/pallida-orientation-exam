using System;
using System.Collections.Generic;
using System.Linq;
using SpringBoot.Entities;
using SpringBoot.Models;
using System.Threading.Tasks;

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

        public List<Car>PoliceCars()
        {
            return CarContext.Cars.Where(x => x.Plate.StartsWith("RB")).ToList();        
        }

        public List<Car>DiplomatCars()
        {
            return CarContext.Cars.Where(x => x.Plate.StartsWith("DT")).ToList();
        }
    }
}
