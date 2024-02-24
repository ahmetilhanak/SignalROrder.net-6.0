using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;

namespace SignalROrderApi.Hubs
{
    public class SignalRHub:Hub
    {
        //SignalRContext context = new SignalRContext();
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly IMoneyCaseService _moneyCaseService;
        private readonly IRestaurantTableService _restaurantTableService;
        private readonly IBookingService _bookingService;
        private readonly INotificationService _notificationService;

        public SignalRHub(ICategoryService categoryService, IProductService productService, IOrderService orderService, IMoneyCaseService moneyCaseService, IRestaurantTableService restaurantTableService, IBookingService bookingService, INotificationService notificationService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _orderService = orderService;
            _moneyCaseService = moneyCaseService;
            _restaurantTableService = restaurantTableService;
            _bookingService = bookingService;
            _notificationService = notificationService;
        }



        //public async Task SendCategoryCount()
        //{
        //    var categoryCount = _categoryService.TCategoryCount();
        //    await Clients.All.SendAsync("ReceiveCategoryCount", categoryCount);
        //}

        //public async Task SendProductCount()
        //{
        //    var productCount = _productService.TProductCount();
        //    await Clients.All.SendAsync("ReceiveProductCount", productCount);
        //}

        //public async Task ActivePassiveCategoryCount()
        //{
        //    var activeCategoryCount = _categoryService.TActiveCategoryCount();
        //    var passiveCategoryCount = _categoryService.TPassiveCategoryCount();
        //    await Clients.All.SendAsync("ReceiveActiveCategoryCount", activeCategoryCount);
        //    await Clients.All.SendAsync("ReceivePassiveCategoryCount", passiveCategoryCount);
        //}

        public static int clientCount { get; set; } = 0;
        public async Task SendStatistics()
        {
            var categoryCount = _categoryService.TCategoryCount();
            await Clients.All.SendAsync("ReceiveCategoryCount", categoryCount);

            var productCount = _productService.TProductCount();
            await Clients.All.SendAsync("ReceiveProductCount", productCount);

            var activeCategoryCount = _categoryService.TActiveCategoryCount();
            await Clients.All.SendAsync("ReceiveActiveCategoryCount", activeCategoryCount);

            var passiveCategoryCount = _categoryService.TPassiveCategoryCount();
            await Clients.All.SendAsync("ReceivePassiveCategoryCount", passiveCategoryCount);

            var productCountByCategoryHamburger = _productService.TProductCountByCategoryNameHamburger();
            await Clients.All.SendAsync("ReceiveProductCountByCategoryHamburger", productCountByCategoryHamburger);

            var productCountByCategoryNameDrink = _productService.TProductCountByCategoryNameDrink();
            await Clients.All.SendAsync("ReceiveProductCountByCategoryDrink", productCountByCategoryNameDrink);

            var productPriceAverage = _productService.TProductPriceAverage();
            await Clients.All.SendAsync("ReceiveProductPriceAverage", productPriceAverage.ToString("0.00")+" ₺");

            var productNameByMaxPrice = _productService.TProductNameByMaxPrice();
            await Clients.All.SendAsync("ReceiveProductNameByMaxPrice", productNameByMaxPrice);

            var productNameByMinPrice = _productService.TProductNameByMinPrice();
            await Clients.All.SendAsync("ReceiveProductNameByMinPrice", productNameByMinPrice);

            var productAveragePriceOfHamburger = _productService.TProductAveragePriceOfHamburger();
            await Clients.All.SendAsync("ReceiveProductAveragePriceOfHamburger", productAveragePriceOfHamburger.ToString("0.00") + " ₺");

            var totalOrderCount = _orderService.TTotalOrderCount();
            await Clients.All.SendAsync("ReceiveTotalOrderCount", totalOrderCount);

            var activeOrderCount = _orderService.TActiveOrderCount();
            await Clients.All.SendAsync("ReceiveActiveOrderCount", activeOrderCount);

            var lastOrderPrice = _orderService.TLastOrderPrice();
            await Clients.All.SendAsync("ReceiveLastOrderPrice", lastOrderPrice.ToString("0.00") + " ₺");

            var totalMoneyCaseAmount = _moneyCaseService.TTotalMoneyCaseAmount();
            await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", totalMoneyCaseAmount.ToString("0.00") + " ₺");

            var restaurantTableCount = _restaurantTableService.TRestaurantTableCount();
            await Clients.All.SendAsync("ReceiveRestaurantTableCount", restaurantTableCount);
        }

        public async Task SendProgress()
        {
            var totalMoneyCaseAmount = _moneyCaseService.TTotalMoneyCaseAmount();
            await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", totalMoneyCaseAmount.ToString("0.00") + " ₺");

            var activeOrderCount = _orderService.TActiveOrderCount();
            await Clients.All.SendAsync("ReceiveActiveOrderCount", activeOrderCount);

            var restaurantTableCount = _restaurantTableService.TRestaurantTableCount();
            await Clients.All.SendAsync("ReceiveRestaurantTableCount", restaurantTableCount);
        }

        public async Task GetBookingList()
        {
            var bookingList = _bookingService.TGetListAll();
            await Clients.All.SendAsync("ReceiveBookingList", bookingList);
        }

        public async Task SentNotification()
        {
            var value = _notificationService.TNotificationCountByStatusFalse();
            await Clients.All.SendAsync("ReceiveNotificationCountByStatusFalse", value);

            var notificationListByStatusFalse = _notificationService.TGetAllNotificationsByStatusFalse();
            await Clients.All.SendAsync("ReceiveNotificationListByStatusFalse", notificationListByStatusFalse);
        }

        public async Task SendTableStatusList()
        {
            var tablelistbystatus = _restaurantTableService.TGetListAll();
            await Clients.All.SendAsync("ReceiveTableListByStatus", tablelistbystatus);
        }

        public async Task SendMessage(string user,string message)
        {
            await Clients.All.SendAsync("ReceiveMesssage",user,message);
        }

        public override async Task OnConnectedAsync()
        {
            clientCount++;
            await Clients.All.SendAsync("ReceiveClientCount", clientCount);
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            clientCount--;
            await Clients.All.SendAsync("ReceiveClientCount", clientCount);
            await base.OnDisconnectedAsync(exception);
        }

    }
}
