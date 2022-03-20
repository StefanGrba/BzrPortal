namespace BZRForumMedia.Server.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using BZRForumMedia.Server.ViewModels;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using BZRForumMedia.Server.Models;

    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public AccountController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model) 
        {
            if (ModelState.IsValid)
            {
                var user = new AppUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    Ime = model.Ime,
                    Prezime = model.Prezime,
                    BrojTelefona = model.BrojTelefona,
                    NazivKompanije = model.NazivKompanije,
                    NazivRadnogMesta = model.NazivPozivije
                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }

                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var currentUser = await _userManager.GetUserAsync(User);

                var result = await _userManager.ChangePasswordAsync(currentUser, "Bzrportal2022.", model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Neuspešan pokušaj logovanja");

            }

            return View(model);
            
        }

        public IActionResult AccessDenied()
        {
            return View("SuperKorisnikError");
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    if (model.Password == "Bzrportal2022.")
                    {
                        return RedirectToAction("ChangePassword", "Account");
                    }

                    return RedirectToAction("Index", "Home");
                }


                ModelState.AddModelError(string.Empty, "Neuspešan pokušaj logovanja");
                
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
