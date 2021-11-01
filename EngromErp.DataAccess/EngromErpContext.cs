using EngromErp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace EngromErp.DataAccess
{
    public class EngromErpContext : DbContext
    {
        public EngromErpContext(DbContextOptions<EngromErpContext> options) 
            : base (options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
