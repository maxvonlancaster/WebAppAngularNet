using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EWebApp.DAL.Entities
{
    public class User
    {
        [Key]
        public long UserId { get; set; }
        public string USerName { get; set; }
        public string Password { get; set; }

    }
}
