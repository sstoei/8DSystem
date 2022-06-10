using _8DSystem.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.DirectoryServices.AccountManagement;

namespace _8DSystem.Controllers
{
    public class AuthController : Controller
    {
        private readonly CoreContext _context;
        public IConfiguration Configuration { get; }
        public AuthController(CoreContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }
        public IActionResult Login(string ReturnUrl)
        {
          //  string domainName = User.Identity.Name;
            //string domainName = "SAT\\thanadol.a"; //User.Identity.Name;
         //  string domainName = "SAT\\sarinya.p"; //User.Identity.Name;
           string domainName = "SAT\\anat"; //User.Identity.Name;
            if (string.IsNullOrWhiteSpace(domainName))
            {
                return Redirect("http://192.168.99.46:9012/");
                //return Redirect("http://localhost:25874");
            }
            var config = Configuration.GetSection("SecurityGroup");
            var AdminGroup = config["AdminGroup"];

            var members = new List<string>();
            int IsInAdminRole = 0;
            var context = new PrincipalContext(ContextType.Domain);
            var principal = UserPrincipal.FindByIdentity(context, domainName);

            foreach (GroupPrincipal group in principal.GetGroups())
            {
                members.Add(group.ToString());
            }

            IsInAdminRole = members.Count(i => i.Equals(AdminGroup));

            bool isAuthenticated = false;

            ClaimsIdentity identity = null;
          

            identity = new ClaimsIdentity(new[] {
                   new Claim(ClaimTypes.Name, domainName),
                     new Claim(ClaimTypes.Role, IsInAdminRole == 1 ? "Admin" : "User")
                }, CookieAuthenticationDefaults.AuthenticationScheme);
            isAuthenticated = true;

            if (isAuthenticated)
            {
                HttpContext.SignOutAsync();

                var principal1 = new ClaimsPrincipal(identity);
                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal1);

                if (!string.IsNullOrEmpty(ReturnUrl))
                {
                    ViewData["ReturnUrl"] = ReturnUrl;
                    if (ReturnUrl.Contains("Set") && IsInAdminRole != 1)
                    {
                        return RedirectToAction(nameof(UnAuthorized));
                    }
                    return Redirect(ReturnUrl);
                }
            }

            return RedirectToAction(nameof(Index), "Home");
        }
      
        public IActionResult UnAuthorized()
        {
            return View();
        }
    }
}
