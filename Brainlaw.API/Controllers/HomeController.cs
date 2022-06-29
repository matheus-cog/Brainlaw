using Microsoft.AspNetCore.Mvc;

namespace Brainlaw.API.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : Controller
    {
        public ContentResult Index()
        {
            var html = System.IO.File.ReadAllText(@"./Content/index.html");
            return base.Content(html, "text/html");
        }
    }
}
