using System.ComponentModel.DataAnnotations;

namespace PresentationApp.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Please provide username")]
        public string UserName { get; set; }

        public string TelegramId { get; set; }

        [Required(ErrorMessage = "Please provide password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
