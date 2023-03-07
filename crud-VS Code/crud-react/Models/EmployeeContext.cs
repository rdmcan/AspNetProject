using Microsoft.EntityFrameworkCore;

namespace crud_react.Models
{
    public class EmployeeContext : DbContext
    {
        // ctor shortcut for constructor // 30:00
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) 
        {
            
        }
        public DbSet<Employee> Employees { get; set;}
    }
}
