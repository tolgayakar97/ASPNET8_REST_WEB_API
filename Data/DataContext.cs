using CarApi_Dotnet8.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarApi_Dotnet8.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Car> Cars { get; set; }
    }
}
