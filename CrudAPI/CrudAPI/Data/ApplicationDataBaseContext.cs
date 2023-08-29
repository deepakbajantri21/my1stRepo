using CrudAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace CrudAPI.Data
{
    public class ApplicationDataBaseContext : DbContext
    {
        public ApplicationDataBaseContext(DbContextOptions<ApplicationDataBaseContext> options) : base(options)
        {
        }
        public DbSet<EmployeeDetailModel> EmployeeData { get; set; }
    }
}
