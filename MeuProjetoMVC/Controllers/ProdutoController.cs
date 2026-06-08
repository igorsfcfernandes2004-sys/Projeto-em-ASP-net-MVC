using Microsoft.AspNetCore.Mvc;

namespace MeuProjetoMVC.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            List<string> produtos = new List<string>()
            {
                "Notebook",
                "Mouse",
                "Teclado",
                "Monitor",
                "Webcam"
            };

            List<double> precos = new List<double>()
            {
                2500,
                80,
                120,
                900,
                70
            };

            ViewBag.Produtos = produtos;
            ViewBag.Precos = precos;

            return View();
        }
    }
}