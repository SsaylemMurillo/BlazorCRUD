using BlazorCRUDNet8.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUDNet8.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
                
        }

        public DbSet<Game> Games { get; set; }
    }
}
