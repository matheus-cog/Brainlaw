using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Brainlaw.API.Controllers
{
    [Route("swagger/v1")]
    [ApiController]
    public class SwaggerController : ControllerBase
    {
        public ContentResult Index()
        {
            var json = System.IO.File.ReadAllText(@"./Content/swagger.json");
            return base.Content(json, "application/json");
        }
    }
}
