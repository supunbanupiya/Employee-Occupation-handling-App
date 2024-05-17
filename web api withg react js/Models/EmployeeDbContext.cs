using Microsoft.EntityFrameworkCore;

namespace web_api_withg_react_js.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<EmployeeModel> EmployeesImageUpload { get; set; }
    }
}
