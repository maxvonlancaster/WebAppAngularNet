using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationApp.DAL.Entities
{
    public class Subject : IEntity
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public User User { get; set; }
        public List<Presentation> Presentations { get; set; } // Navigational property
    }
}
