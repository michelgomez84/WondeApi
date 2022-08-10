using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebMvc.Models;
using WondeApiServices.IServices;

namespace WebMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ISchoolService _schoolService;

        public HomeController(ILogger<HomeController> logger, ISchoolService schoolService)
        {
            _logger = logger;
            _schoolService=schoolService;
        }

        //
        public async Task<IActionResult> Index()
        {
            // LLamamos al servico que retorna lista de escuelas
            // Le pasamos como referencia el ApiToken -> que es el token de acceso que le dan al cliente para consumir el servicio
            // El otro parametro es el school status ... 
            var data = await _schoolService.GetAll("82d1a6bd415d77309cc7fb7520ded1eabc9c0682", WondeApiModel.schoolStatus.All);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}