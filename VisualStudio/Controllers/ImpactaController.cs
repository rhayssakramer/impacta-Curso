using Microsoft.AspNetCore.Mvc;

namespace cursoImpacta.Models
{
    public class ImpactaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Aluno()
        {
            return View();
        }

        public IActionResult Curso => View();
    }
}
