﻿namespace Online_Shop___BackEnd.Models
{
    public class BasketProduct
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int BasketId { get; set; }
        public Basket Basket { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
