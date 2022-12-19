using Microsoft.EntityFrameworkCore;
using TruckManager.src.Models;

namespace TruckManager.src.Context
{
    public class TruckContext : DbContext
    {
        public TruckContext(DbContextOptions<TruckContext> options) : base(options)
        {
            
        }

        public DbSet<Truck> Trucks { get; set; }
    }
}