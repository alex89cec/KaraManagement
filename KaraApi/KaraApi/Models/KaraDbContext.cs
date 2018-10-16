using Microsoft.EntityFrameworkCore;        

namespace KaraApi.Models
{
    public class KaraDbContext: DbContext
    {
        public KaraDbContext(DbContextOptions<KaraDbContext> options)
          : base(options)
        {
        }

        public DbSet<Student> StudentsList { get; set; }
    }
}
