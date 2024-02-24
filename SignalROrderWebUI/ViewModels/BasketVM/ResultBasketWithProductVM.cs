namespace SignalROrderWebUI.ViewModels.BasketVM
{
    public class ResultBasketWithProductVM
    {
        public int BasketID { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int RestaurantTableID { get; set; }
        // public RestaurantTable RestaurantTable { get; set; }
    }
}
