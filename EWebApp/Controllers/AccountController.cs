using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using EWebApp.BLL.Interfaces;
using EWebApp.DAL.Entities;
using EWebApp.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace EWebApp.Controllers
{
    public class AccountController : Controller
    {
        private IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Login() 
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register() 
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model) 
        {
            if (ModelState.IsValid) 
            {
                User user = await _accountService.GetUserByLogin(model.Email, model.Password);
                if (user != null) 
                {
                    await Authenticate(model.Email);
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Incorrect login info");
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model) 
        {
            if (ModelState.IsValid) 
            {
                User user = await _accountService.GetUserByEmail(model.Email);
                if (user == null)
                {
                    await _accountService.AddUser(new User 
                    {
                        Email = model.Email,
                        Password = model.Password
                    });
                    await Authenticate(model.Email);
                    return RedirectToAction("Index", "Home");
                }
                else 
                {
                    ModelState.AddModelError("", "That email is already linked to an account");
                }
            }
            return View(model);
        }

        private async Task Authenticate(string userName) 
        {
            // create one claim 
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };

            // create object ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, 
                "ApplicationCookie", 
                ClaimsIdentity.DefaultNameClaimType, 
                ClaimsIdentity.DefaultRoleClaimType);

            // installation of auth cookies 
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));

        }

        public async Task<IActionResult> Logout() 
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

    }
}
