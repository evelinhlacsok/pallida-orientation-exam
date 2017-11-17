using System;
using Microsoft.EntityFrameworkCore;
using SpringBoot.Models;

namespace SpringBoot.Entities
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}
