using System;
using SpringBoot.Entities;

namespace SpringBoot.Repositories
{
    public class CarRepository
    {
        CarContext CarContext;

        public CarRepository (CarContext carContext)
        {
            CarContext = carContext;
        }
    }
}
