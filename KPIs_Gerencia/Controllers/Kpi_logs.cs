using Microsoft.AspNetCore.Mvc;

namespace KPIs_Gerencia.Controllers
{
    public class Kpi_logs : Controller
    {
        public IActionResult Crear() 
        { 
            return View();
        }
        


        [HttpPost]
        public IActionResult Crear(Kpi_logs kpi_Logs) 
        {
        return View();
        }
    }
}

