using Microsoft.AspNetCore.Mvc;

namespace MeuProjetoMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nome = "Igor";
            ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
            ViewBag.Semestre = "1º Semestre";

            return View();
        }
    }
}
        public IActionResult Detalhes(int id)
        {
            return Content($"ID do aluno recebido: {id}");
        }
    }
}

