using System.ComponentModel.DataAnnotations;

namespace Online_Shop___BackEnd.ViewModels.AccountViewModels
{
    public class ChangePasswordVM
    {
        [Required, DataType(DataType.Password)]
        public string CurrentPassword { get; set; }

        [Required, DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required,
            DataType(DataType.Password), Compare(nameof(NewPassword))]
        public string NewConfirmPassword { get; set; }
    }
}
