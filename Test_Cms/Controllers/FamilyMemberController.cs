using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Test_Cms.Models;

namespace Test_Cms.Controllers
{
    public class FamilyMemberController : Controller
    {
        private readonly ILogger<FamilyMemberController> _logger;
        private readonly IConfiguration configuration;
        public FamilyMemberController(ILogger<FamilyMemberController> logger, IConfiguration config)
        {
            configuration = config;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var rows = new Context().GetContacts(configuration.GetConnectionString("DefaultConnection"), 2);
            return View(rows);
        }
    }
}
