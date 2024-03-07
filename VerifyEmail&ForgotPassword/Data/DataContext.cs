using Microsoft.EntityFrameworkCore;
using VerifyEmail_ForgotPassword.Models;

namespace VerifyEmail_ForgotPassword.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=UserDbVerifyEmail; Trusted_Connection=True; TrustServerCertificate=True;");
        }

        public DbSet<User> Users => Set<User>();
    }
}
