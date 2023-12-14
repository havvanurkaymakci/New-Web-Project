using Microsoft.EntityFrameworkCore;
using New_Web_Project.Models.Login;
using New_Web_Project.Controllers;


namespace New_Web_Project.Models
{
    public class FlightSystemContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=HAVVANUR\MSSQLSERVER01; 
             Database=FlightSystem;Trusted_Connection=True;");
        }
    }
}
