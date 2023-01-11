namespace DukkanTek.Models.Response
{
    public class ProductsDetails
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int Sold { get; set; }
        public int Damaged { get; set; }
        public int InStock { get; set; }
    }
}