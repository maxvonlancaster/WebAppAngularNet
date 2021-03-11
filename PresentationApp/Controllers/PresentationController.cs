using Microsoft.AspNetCore.Mvc;
using PresentationApp.BLL.Services;
using PresentationApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationApp.Controllers
{
    public class PresentationController : ControllerBase
    {
        private IService<Presentation> _presentationService;

        public PresentationController(IService<Presentation> presentationService)
        {
            _presentationService = presentationService;
        }
    }
}
