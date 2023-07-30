using System.ComponentModel.DataAnnotations;

namespace Online_Shop___BackEnd.ViewModels.AccountViewModels
{
    public class ConfirmAccountVM
    {
        public string Email { get; set; }
        [Required]
        public string OTP { get; set; }
    }
}
