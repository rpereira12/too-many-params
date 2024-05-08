using Microsoft.EntityFrameworkCore;
using too_many_params.Domain;

namespace too_many_params.Infra
{
    public class ParamsDbContext : DbContext
    {
        public ParamsDbContext()
        {
        }

        public ParamsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contract> Contracts { get; set; }
        public DbSet<ContractDetails> ContractDetails { get; set; }
        public DbSet<ContractStatus> ContractStatus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySql(
                "Server=localhost;Port=3309;Database=mydatabase;Uid=myuser;Pwd=mypassword;",
                new MySqlServerVersion(new Version(8, 0, 21)));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contract>()
                .ToTable("Contracts")
                .OwnsOne(c => c.Details, d =>
                {
                    d.Property(d => d.ContractNumber).HasColumnName("ContractNumber");
                    d.Property(d => d.ClientName).HasColumnName("ClientName");
                    d.Property(d => d.StartDate).HasColumnName("StartDate");
                    d.Property(d => d.EndDate).HasColumnName("EndDate");
                    d.Property(d => d.Amount).HasColumnName("Amount");
                    d.Property(d => d.Description).HasColumnName("Description");
                    d.ToTable("Contracts");
                });

            modelBuilder.Entity<Contract>()
                .OwnsOne(c => c.Status, s =>
                {
                    s.Property(s => s.IsActive).HasColumnName("IsActive");
                    s.Property(s => s.IsApproved).HasColumnName("IsApproved");
                    s.Property(s => s.IsSigned).HasColumnName("IsSigned");
                    s.Property(s => s.IsCancelled).HasColumnName("IsCancelled");
                    s.ToTable("Contracts");
                });
        }
    }
}
