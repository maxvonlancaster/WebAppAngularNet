using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationApp.DAL.Entities
{
    public class Presentation : IEntity
    {
        public int Id { get; set; }
        public string PresentationName { get; set; }
        public byte[] File { get; set; }
        public Subject Subject { get; set; }
        public List<Question> Questions { get; set; }
    }
}
