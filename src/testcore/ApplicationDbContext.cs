using Microsoft.EntityFrameworkCore;

namespace testcore
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.ToTable("Bill");
            });

        }
        public virtual DbSet<Bill> Bills{ get; set; }

    }
}
    public class Bill
    {
        public int Id { get; set; }

    public string sCode { get; set; }
    }