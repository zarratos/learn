using System.Collections.Generic;

namespace DAL
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public double ProductDiscount { get; set; }
        public string ProductDescription { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public int CategoryId { get; set; }
    }
}