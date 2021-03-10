using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationApp.DAL.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string TelegramId { get; set; }
        public string Password { get; set; }

        public List<Subject> Subjects { get; set; }
    }
}
