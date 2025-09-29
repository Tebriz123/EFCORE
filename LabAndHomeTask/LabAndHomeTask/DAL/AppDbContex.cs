using LabAndHomeTask.Models;
using Microsoft.EntityFrameworkCore;


namespace LabAndHomeTask.DAL
{
    internal class AppDbContex:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=Tebriz;database=LabAndHome;trusted_connection=true;integrated security=true;encrypt=false;");
        }


        public DbSet<AppProduct> AppProducts { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
