using Microsoft.AspNetCore.Mvc;

namespace KPIs_Gerencia.Controllers
{
    public class UsuariosController:Controller
    {
        public IActionResult Registro()
        {
            return View();
        }
    }
}
