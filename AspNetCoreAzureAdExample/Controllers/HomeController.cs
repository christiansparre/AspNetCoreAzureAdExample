using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreAzureAdExample.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        [HttpGet("secret-place")]
        public IActionResult VerySecretPlace()
        {
            return Content($"Welcome {User.Identity.Name}");
        }
    }
}