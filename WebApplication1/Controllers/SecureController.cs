using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DotnetcoreMVCWithAuthentication.Controllers
{
    [Authorize]
    public class SecureController : Controller
    {
        public IActionResult Index()
        {
            var name = User.Identity?.Name ?? "unknown";
            ViewBag.Name = name;
            return View();
        }
    }
}