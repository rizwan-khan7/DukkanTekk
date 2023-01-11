namespace DukkanTek.Models.Response
{
    public class OrderDetails
    {
        public long OrderId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public Decimal TotalAmount { get; set; }
    }
}