using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Site.Modulos.Produtos.Controllers
{
    [Area("Produtos")]
    //[Route("produtos")]
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Busca()
        {
            return View();
        }
    }
}
