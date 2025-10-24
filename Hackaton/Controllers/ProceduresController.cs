using Hackaton.Services;
using Microsoft.AspNetCore.Mvc;

namespace Hackaton.Controllers
{
    public class ProceduresController : Controller
    {
        private readonly JuryServices _juryServices;

        public ProceduresController(JuryServices juryServices)
        {
            _juryServices = juryServices;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
