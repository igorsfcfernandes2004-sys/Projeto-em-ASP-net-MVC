using Microsoft.AspNetCore.Mvc;
using MeuProjetoMVC.Models;

namespace MeuProjetoMVC.Controllers
{
    public class ImcController : Controller
    {
        [HttpGet]
        public IActionResult Calcular()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(Imc imc)
        {
            if (!ModelState.IsValid)
            {
                return View(imc);
            }

            imc.Resultado = imc.Peso / (imc.Altura * imc.Altura);

            return View("Resultado", imc);
        }
    }
}