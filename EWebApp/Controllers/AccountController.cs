using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EWebApp.BLL.Interfaces;
using EWebApp.Models;
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

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public async Task Login(LoginModel model) 
        {
        
        }

        public async Task Register(RegisterModel model) 
        {
        
        }

        private async Task Authenticate(string userName) 
        {
        
        }

        public async Task Logout() 
        {
        
        }

    }
}
