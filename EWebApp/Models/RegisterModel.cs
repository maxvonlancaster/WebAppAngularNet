using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EWebApp.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Please specify your Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please specify your Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
