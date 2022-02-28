namespace Cart.Models
{
    public class CartMaster
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public int OrderId { get; set; }

        // [INITIATED, SUCCESS, FAILED, CHECKOUT], 
        public string OrderStatus { get; set; }
        public List<CartDetails> Products { get; set; }
    }
}