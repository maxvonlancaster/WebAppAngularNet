using Microsoft.AspNetCore.Mvc;
using PresentationApp.BLL.Services;
using PresentationApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationApp.Controllers
{
    public class SubjectController : ControllerBase
    {
        private IService<Subject> _subjectService;

        public SubjectController(IService<Subject> subjectService)
        {
            _subjectService = subjectService;
        }
    }
}
