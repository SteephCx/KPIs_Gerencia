using Dapper;
using KPIs_Gerencia.Controllers;
using Microsoft.Data.SqlClient;

namespace KPIs_Gerencia.Services
{
    //Utilizamos el principo de inversion de dependencias que dice que nuestras clases
    //deben de depender de abstacciones y no de tipos concretos. 

    public interface IRepositorio_Kpilogs
    {

    }
    public class Repositorio_Kpilogs : IRepositorio_Kpilogs
    {
        private readonly string connectionString;
        public Repositorio_Kpilogs (IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Crear(Kpi_logs kpi_Logs)
        {
            using var connection = new SqlConnection(connectionString);
         //   var id = connection.QuerySingle<int>()
        }
    }
}
