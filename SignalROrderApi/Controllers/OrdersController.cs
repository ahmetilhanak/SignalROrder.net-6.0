using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.OrderDto;
using SignalR.EntityLayer.Entities;

namespace SignalROrderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult OrderList()
        {
            var values = _orderService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateOrder(CreateOrderDto createOrderDto)
        {
            Order order = new Order()
            {
                TableNumber=createOrderDto.TableNumber,
                Description = createOrderDto.Description,
                OrderDate = createOrderDto.OrderDate,
                TotalPrice=createOrderDto.TotalPrice,
               
            };
            //_aboutSevice.TAdd(createAboutDto);
            _orderService.TAdd(order);
            return Ok("It is added on Order");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {
            var value = _orderService.TGetByID(id);
            _orderService.TDelete(value);
            return Ok("Order is deleted");
        }

        [HttpPut]
        public IActionResult UpdateOrder(UpdateOrderDto updateOrderDto)
        {
            Order order = new Order()
            {
                OrderID=updateOrderDto.OrderID,
                TableNumber = updateOrderDto.TableNumber,
                Description = updateOrderDto.Description,
                OrderDate = updateOrderDto.OrderDate,
                TotalPrice = updateOrderDto.TotalPrice,

            };
            // _aboutSevice.TUpdate(updateAboutDto);
            _orderService.TUpdate(order);
            return Ok("It is Updated");
        }

        [HttpGet("GetOrder/{id}")]
        public IActionResult GetOrder(int id)
        {
            var value = _orderService.TGetByID(id);
            return Ok(value);
        }

        [HttpGet("TotalOrderCount")]
        public IActionResult TotalOrderCount()
        {
            var value = _orderService.TTotalOrderCount();
            return Ok(value);
        }

        [HttpGet("ActiveOrderCount")]
        public IActionResult ActiveOrderCount()
        {
            var value = _orderService.TActiveOrderCount();
            return Ok(value);
        }

        [HttpGet("LastOrderPrice")]
        public IActionResult LastOrderPrice()
        {
            var value = _orderService.TLastOrderPrice();
            return Ok(value);
        }

        [HttpGet("TodayTotalPrice")]
        public IActionResult TodayTotalPrice()
        {
            var value = _orderService.TTodayTotalPrice();
            return Ok(value);
        }


    }
}
