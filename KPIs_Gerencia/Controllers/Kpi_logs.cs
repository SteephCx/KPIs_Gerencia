using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace KPIs_Gerencia.Controllers
{
    public class Kpi_logs : Controller
    {

        private readonly string connectionstring;
        //variable para que funcione el query
        private readonly IConfiguration _configuration;


        public Kpi_logs(IConfiguration configuration)
        {
            connectionstring = configuration.GetConnectionString("DefaultConnection");
            _configuration = configuration;
        }
        public IActionResult Crear()
        {
            using (var connection = new SqlConnection(connectionstring))
            {
                var query = connection.Query("Select 1").FirstOrDefault();
            }
            return View();
        }

        //[HttpGet]
//public IActionResult ConsultarNoempleado(int NO_EMPLEADO)
//{
//    string connectionString = _configuration.GetConnectionString("DefaultConnection");

//    using (var connection = new SqlConnection(connectionString))
//    {
//        connection.Open();
//        string query = @"
//            SELECT 
//                E.[No_EMPLEADO],
//                D.[Departamento],
//                E.[NOMBRE],
//                E.[APELLIDO],
//                I.ID_DEP1
//            FROM [KPIs].[dbo].[TB_EMPLEADOS] AS E
//            JOIN TB_DEPARTAMENTOS AS D ON E.ID_DEP2 = D.ID_DEP
//            JOIN TB_INDICADORES AS I ON E.ID_DEP2 = I.ID_DEP1
//            WHERE E.No_EMPLEADO = @NO_EMPLEADO AND ACTIVO = 1;
//        ";

//        var resultado = connection.QueryFirstOrDefault(query, new { NO_EMPLEADO });

//        // Crear una instancia de Kpi_logs y asignar valores
//        Kpi_logs modeloTemporal = new Kpi_logs
//        {
//            NO_EMPLEADO = resultado.No_EMPLEADO,
//            // Asigna los demás campos según corresponda
//        };

//        // Puedes hacer algo con el resultado temporal, por ejemplo, pasarlo a la vista
//        return View("", modeloTemporal);
//    }
//}

  
        
        
        
        
        
        //    [HttpGet]
    //    public IActionResult ConsultarNoempleado(int NO_EMPLEADO)
    //    {

    //        string connectionString = _configuration.GetConnectionString("DefaultConnection");

    //        using (var connection = new SqlConnection(connectionString))
    //        {
    //            connection.Open();
    //            string query = @"
    //    SELECT 
    //        E.[No_EMPLEADO],
    //        D.[Departamento],
    //        E.[NOMBRE],
    //        E.[APELLIDO],
    //        I.ID_DEP1
    //    FROM [KPIs].[dbo].[TB_EMPLEADOS] AS E
    //    JOIN TB_DEPARTAMENTOS AS D ON E.ID_DEP2 = D.ID_DEP
    //    JOIN TB_INDICADORES AS I ON E.ID_DEP2 = I.ID_DEP1
    //    WHERE E.No_EMPLEADO = @NO_EMPLEADO AND ACTIVO = 1;
    //";

    //            var resultado = connection.QueryFirstOrDefault<Kpi_logs>(query, new { NO_EMPLEADO });

    //            // Puedes hacer algo con el resultado, por ejemplo, pasarlo a la vista
    //            return View("", resultado);
    //        }
    //    }
    }
}


//[HttpGet]
//public IActionResult ConsultarNoempleado(int NO_EMPLEADO)
//{
//    string connectionString = _configuration.GetConnectionString("DefaultConnection");

//    using (var connection = new SqlConnection(connectionString))
//    {
//        connection.Open();
//        string query = @"
//            SELECT 
//                E.[No_EMPLEADO],
//                D.[Departamento],
//                E.[NOMBRE],
//                E.[APELLIDO],
//                I.ID_DEP1
//            FROM [KPIs].[dbo].[TB_EMPLEADOS] AS E
//            JOIN TB_DEPARTAMENTOS AS D ON E.ID_DEP2 = D.ID_DEP
//            JOIN TB_INDICADORES AS I ON E.ID_DEP2 = I.ID_DEP1
//            WHERE E.No_EMPLEADO = @NO_EMPLEADO AND ACTIVO = 1;
//        ";

//        var resultado = connection.QueryFirstOrDefault(query, new { NO_EMPLEADO });

//        // Crear una instancia de Kpi_logs y asignar valores
//        Kpi_logs modeloTemporal = new Kpi_logs
//        {
//            NO_EMPLEADO = resultado.No_EMPLEADO,
//            // Asigna los demás campos según corresponda
//        };

//        // Puedes hacer algo con el resultado temporal, por ejemplo, pasarlo a la vista
//        return View("", modeloTemporal);
//    }
//}
