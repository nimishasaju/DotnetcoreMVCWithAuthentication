using Microsoft.AspNetCore.Mvc;

namespace DotnetcoreMVCWithAuthentication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}