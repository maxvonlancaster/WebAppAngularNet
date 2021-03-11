using Microsoft.AspNetCore.Mvc;
using PresentationApp.BLL.Services;
using PresentationApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationApp.Controllers
{
    public class AccountController : ControllerBase
    {
        private IService<User> _userService;

        public AccountController(IService<User> userService)
        {
            _userService = userService;
        }
    }
}
