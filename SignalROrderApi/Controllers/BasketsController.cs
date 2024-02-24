using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.BasketDto;
using SignalR.EntityLayer.Entities;

namespace SignalROrderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly IBasketService _basketService;

        public BasketsController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [HttpGet]
        public IActionResult BasketList()
        {
            var values = _basketService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateBasket(CreateBasketDto createBasketDto)
        {
            Basket basket = new Basket()
            {
                Price = createBasketDto.Price,
                Count = createBasketDto.Count,
                TotalPrice = createBasketDto.TotalPrice,
                ProductID = createBasketDto.ProductID,
                RestaurantTableID = createBasketDto.RestaurantTableID
            };
            //_aboutSevice.TAdd(createAboutDto);
            _basketService.TAdd(basket);
            return Ok("It is added on Basket");
        }

        [HttpPost("AddBasket")]
        public IActionResult AddBasket(AddBasketIdDto addBasketIdDto)
        {
            using var context = new SignalRContext();
            var productForBasket = context.Products.Where(z => z.ProductID == addBasketIdDto.Id).FirstOrDefault();
            Basket basket = new Basket()
            {
                RestaurantTableID = 4,
                ProductID = productForBasket.ProductID,
                Price = productForBasket.Price,
                Count = 1,
                TotalPrice = 0,
                
            };
            _basketService.TAdd(basket);
            return Ok("It is added on Basket");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBasket(int id)
        {
            var value = _basketService.TGetByID(id);
            _basketService.TDelete(value);
            return Ok("Basket is deleted");
        }

        [HttpPut]
        public IActionResult UpdateBasket(UpdateBasketDto updateBasketDto)
        {
            Basket basket = new Basket()
            {
                BasketID = updateBasketDto.BasketID,
                Price = updateBasketDto.Price,
                Count = updateBasketDto.Count,
                TotalPrice = updateBasketDto.TotalPrice,
                ProductID = updateBasketDto.ProductID,
                RestaurantTableID = updateBasketDto.RestaurantTableID
            };
            // _aboutSevice.TUpdate(updateAboutDto);
            _basketService.TUpdate(basket);
            return Ok("It is Updated");
        }

        [HttpGet("GetBasket/{id}")]
        public IActionResult GetBasket(int id)
        {
            var value = _basketService.TGetByID(id);
            return Ok(value);
        }

        [HttpGet("GetBasketByRestaurantTableNumber/{id}")]
        public IActionResult GetBasketByRestaurantTableNumber(int id)
        {
            var value = _basketService.TGetBasketByRestaurantTableNumber(id);
            return Ok(value);
        }

        [HttpGet("GetBasketByRestaurantTableNumberWithProductName/{productName}")]
        public IActionResult GetBasketByRestaurantTableNumberWithProductName(string productName)
        {
            var value = _basketService.TGetBasketByRestaurantTableNumberWithProductName(productName);
            return Ok(value);
        }

        [HttpGet("GetBasketWithProductNameByRestaurantTableNumber/{id}")]
        public IActionResult GetBasketWithProductNameByRestaurantTableNumber(int id)
        {
            var value = _basketService.TGetBasketWithProductNameByRestaurantTableNumber(id);
            return Ok(value);
        }
    }
}

