using AgenziaViaggioMVC.Models;

namespace AgenziaViaggioMVC.Database
{
    public class AgencyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;"
                                        + "Database=AgenziaViaggioMVC;"
                                        + "Integrated Security=True;"
                                        + "TrustServerCertificate=True");
        }
    }
}