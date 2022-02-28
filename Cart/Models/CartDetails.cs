namespace Cart.Models
{
    public class CartDetails
    {
        public int Id { get; set; }

      //  public int CartId { get; set; }

        public int ProductId { get; set; }
        public double ProductPrice { get; set; }
        public int Quantity { get; set; }


    }
}
