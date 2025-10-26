using Microsoft.AspNetCore.Mvc;
using DotnetcoreMVCWithAuthentication.Models;
using DotnetcoreMVCWithAuthentication.Services;

namespace DotnetcoreMVCWithAuthentication.Controllers
{
    public class AccountController : Controller
    {
        private readonly IJwtTokenService _jwtService;

        public AccountController(IJwtTokenService jwtService)
        {
            _jwtService = jwtService;
        }

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(UserCredentials creds)
        {
            // Replace this with real user validation (DB, Identity, etc.)
            if (creds is null || creds.Username != "admin" || creds.Password != "P@ssw0rd!")
            {
                ModelState.AddModelError(string.Empty, "Invalid username or password");
                return View();
            }

            var token = _jwtService.GenerateToken(creds.Username);

            // Show token in the view for demo purposes.
            ViewBag.Token = token;
            return View();
        }
    }
}