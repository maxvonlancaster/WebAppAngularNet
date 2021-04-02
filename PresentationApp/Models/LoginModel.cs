using System.ComponentModel.DataAnnotations;

namespace PresentationApp.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please provide username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please provide password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
