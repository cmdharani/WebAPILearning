using Microsoft.EntityFrameworkCore;
using WebAPIAuthPratice.Model;

namespace WebAPIAuthPratice.Data
{
    public class EmpDbContext:DbContext
    {
        public EmpDbContext(DbContextOptions<EmpDbContext> options):base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().HasKey(e => e.Id);

            modelBuilder.Entity<Employee>().HasData(

                [
                    new Employee 
                    { Id = 1, Email = "test@abc.com",FirstName="madhu",LastName="dharani" }
                ]          
                
                
                );
        }
    }
}
