using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationApp.DAL.Entities
{
    public class Question : IEntity
    {
        public int Id { get; set; }
        public int Page { get; set; }
        public string QuestionText { get; set; }
        public string OptionOne { get; set; }
        public string OptionTwo { get; set; }
        public string OptionThree { get; set; }
        public string OptionFour { get; set; }
        public int CorrectOption { get; set; }
        public Presentation Presentation { get; set; }
    }
}
