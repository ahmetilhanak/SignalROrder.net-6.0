namespace SignalROrderWebUI.ViewModels.BasketVM
{
    public class CreateBasketVM
    {
       
        public decimal Price { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }
        public int ProductID { get; set; }
        //public Product Product { get; set; }
        public int RestaurantTableID { get; set; }
        //public RestaurantTable RestaurantTable { get; set; }
    }
}
