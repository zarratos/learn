using System.Drawing.Printing;
using System.Web;

namespace Shop.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public double ProductDiscount { get; set; }
        public string ProductDescription { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
        public int CategoryId { get; set; }
    }
}