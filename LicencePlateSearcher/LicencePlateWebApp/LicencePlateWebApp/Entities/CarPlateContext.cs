using LicencePlateWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LicencePlateWebApp.Entities
{
    public class CarPlateContext : DbContext
    {
        public CarPlateContext(DbContextOptions<CarPlateContext> options) : base(options)
        {
        }
        public DbSet<CarPlate> CarPlates { get; set; }
    }


}
