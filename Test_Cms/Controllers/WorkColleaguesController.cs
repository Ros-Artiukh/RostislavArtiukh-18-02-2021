using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Test_Cms.Models;

namespace Test_Cms.Controllers
{
    public class WorkColleaguesController : Controller
    {
        private readonly ILogger<WorkColleaguesController> _logger;
        private readonly IConfiguration configuration;
        public WorkColleaguesController(ILogger<WorkColleaguesController> logger, IConfiguration config)
        {
            configuration = config;
            _logger = logger;
        }
       
        public IActionResult Index()
        {
         var rows =  new Context().GetContacts(configuration.GetConnectionString("DefaultConnection"),  1);
            return View(rows);
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
