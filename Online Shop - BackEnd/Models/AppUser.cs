using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Online_Shop___BackEnd.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string OTP { get; set; }
        public Basket Basket { get; set; }
        public List<ProductComent> ProductComents { get; set; }
        public List<BlogComment> BlogComments { get; set; }
    }
}
