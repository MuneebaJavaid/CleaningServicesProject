using Microsoft.EntityFrameworkCore;

namespace SaafCleaningProject.Models
{
    public class ClientDbContext:DbContext
    {
        public ClientDbContext(DbContextOptions<ClientDbContext> options) : base(options)
        {

        }
        public DbSet<DataModel> CDataModels { get; set; }
    }
}
