using DemoApp.Models;
using Microsoft.EntityFrameworkCore;
namespace DemoApp.Data
{
    public class DemoAppDbContext : DbContext
    {
        public DbSet<MenuEntity> MenuEntities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=mysql06.trwww.com;database=arcaserv_DemoApp;user=demouser;password=Demouser123456!;convert zero datetime=True");
        }


    }
}
