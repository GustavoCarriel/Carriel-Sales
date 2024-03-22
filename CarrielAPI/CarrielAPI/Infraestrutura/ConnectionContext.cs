using CarrielAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace CarrielAPI.Infraestrutura
{
    public class ConnectionContext : DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySQL(
                "Server=localhost;" +
                "Port=3306;" +
                "Database=carriel_sales;" +
                "User=root;" +
                "Password=@Gustavo08;");
    }
}
