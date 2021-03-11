using Microsoft.AspNetCore.Mvc;
using PresentationApp.BLL.Services;
using PresentationApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationApp.Controllers
{
    public class QuestionController : ControllerBase
    {
        private IService<Question> _questionService;

        public QuestionController(IService<Question> questionService)
        {
            _questionService = questionService;
        }
    }
}
