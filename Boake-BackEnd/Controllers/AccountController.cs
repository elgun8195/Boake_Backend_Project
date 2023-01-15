using Boake_BackEnd.Helpers;
using Boake_BackEnd.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using System;
using Boake_BackEnd.ViewModels;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;
using System.Data;

namespace Boake_BackEnd.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;
        private RoleManager<IdentityRole> _roleManager;
        private readonly IWebHostEnvironment _env;

        public AccountController(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            IWebHostEnvironment env)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _env = env;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        //123456Aa!
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid) return View();

            AppUser user = new AppUser
            {UserName=register.Username,
                Firstname = register.Firstname,
                Lastname=register.Lastname,
                Email = register.Email
            };

            IdentityResult result = await _userManager.CreateAsync(user, register.Password);
            if (!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }


            await _signInManager.SignInAsync(user, isPersistent: true);
            await _userManager.AddToRoleAsync(user, "Member");         

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM, string returnurl)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            AppUser dbUser = await _userManager.FindByEmailAsync(loginVM.Email);
            if (dbUser == null)
            {
                ModelState.AddModelError("", "Ya email ya da Password sehvdir");
                return View(loginVM);
            }
            SignInResult result = await _signInManager.PasswordSignInAsync(dbUser, loginVM.Password, loginVM.RememerMe, true);
            if (!result.Succeeded)
            {
                if (result.IsLockedOut)
                {
                    ModelState.AddModelError("", "Your account is blocked because you write wrong password or username.You try after 5 minutes");
                    return View();
                }
                ModelState.AddModelError("", "Username or password is incorrect");
                return View();

            }

            if (result.IsLockedOut)
            {
                ModelState.AddModelError("", "Your Account Is Lock Out");
                return View(loginVM);
            }

            //if (!result.Succeeded)
            //{
            //    ModelState.AddModelError("", "Ya Email ya da Password sehvdir");
            //    return View(loginVM);
            //}

            if (returnurl == null)
            {
                return RedirectToAction("index", "home");
            }
            foreach (var item in await _userManager.GetRolesAsync(dbUser))
            {
                if (item.Contains(Roless.Admin.ToString()))
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return Redirect(returnurl);

        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }
        public async Task CreateRole()
        {
            foreach (var item in Enum.GetValues(typeof(Roless)))
            {
                if (!await _roleManager.RoleExistsAsync(item.ToString()))
                {
                    await _roleManager.CreateAsync(new IdentityRole { Name = item.ToString() });
                }
            }
        }
 
       
 
    }
}
