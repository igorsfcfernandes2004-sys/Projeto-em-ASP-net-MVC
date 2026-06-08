using Microsoft.AspNetCore.Mvc;
using MeuProjetoMVC.Models;

namespace MeuProjetoMVC.Controllers
{
    public class AlunoController : Controller
    {
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Aluno aluno)
        {
            if (!ModelState.IsValid)
            {
                return View(aluno);
            }

            return View("Confirmacao", aluno);
        }
    }
}