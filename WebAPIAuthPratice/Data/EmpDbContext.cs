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


        public DbSet<User> Users { get; set; }

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


            modelBuilder.Entity<User>().HasKey(e => e.Id);

            modelBuilder.Entity<User>().HasData([
                 new User{FirstName="system",Id=1,Username="system", isActive=true,LastName="",Password="system" }
                ]); ;
        }
    }
}
