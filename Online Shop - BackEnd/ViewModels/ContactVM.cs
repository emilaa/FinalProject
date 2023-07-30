using Online_Shop___BackEnd.Models;
using System.ComponentModel.DataAnnotations;

namespace Online_Shop___BackEnd.ViewModels
{
    public class ContactVM
    {
        public Contact Contact { get; set; }
        public ContactUs ContactUs { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
