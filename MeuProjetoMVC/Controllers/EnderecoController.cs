using Microsoft.AspNetCore.Mvc;
using MeuProjetoMVC.Models;

namespace MeuProjetoMVC.Controllers
{
    public class EnderecoController : Controller
    {
        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Endereco endereco)
        {
            if (!ModelState.IsValid)
                return View(endereco);

            return View("Confirmacao", endereco);
        }
    }
}