using System;

namespace Online_Shop___BackEnd.Models
{
    public class ProductComent : BaseEntity
    {
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
