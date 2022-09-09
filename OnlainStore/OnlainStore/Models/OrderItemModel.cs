namespace OlineStore.Models
{
    public class OrderItemModel
    {
        public int ProductId { get; set; }
        public int Count { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        
    }
}
