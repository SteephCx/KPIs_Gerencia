using Microsoft.EntityFrameworkCore;
// Lo cree para que hubiera un modelo para la conexion
namespace KPIs_Gerencia.Models
{
    public class ConexionKpis : DbContext
    {
        public ConexionKpis(DbContextOptions<ConexionKpis> options) : base(options)
        {
        }
        public DbSet<kpi_logs> Kpi_Logs { get; set; }
    }
}