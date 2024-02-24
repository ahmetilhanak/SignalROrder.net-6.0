using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.RestaurantTableDto;
using SignalR.EntityLayer.Entities;

namespace SignalROrderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantTableController : ControllerBase
    {
        private readonly IRestaurantTableService _restaurantTableService;

        public RestaurantTableController(IRestaurantTableService restaurantTableService)
        {
            _restaurantTableService = restaurantTableService;
        }


        [HttpGet]
        public IActionResult RestaurantTableList()
        {
            var values = _restaurantTableService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateRestaurantTable(CreateRestaurantTableDto createRestaurantTableDto)
        {
            RestaurantTable restaurantTable = new RestaurantTable()
            {
                Name=createRestaurantTableDto.Name,
                Status=false
            };
            
            _restaurantTableService.TAdd(restaurantTable);
            return Ok("It is added on RestaurantTable");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRestaurantTable(int id)
        {
            var value = _restaurantTableService.TGetByID(id);
            _restaurantTableService.TDelete(value);
            return Ok("RestaurantTable is deleted");
        }

        [HttpPut]
        public IActionResult UpdateRestaurantTable(UpdateRestaurantTableDto updateRestaurantTableDto)
        {
            RestaurantTable restaurantTable = new RestaurantTable()
            {
                RestaurantTableID=updateRestaurantTableDto.RestaurantTableID,
                Name = updateRestaurantTableDto.Name,
                Status = updateRestaurantTableDto.Status
            };
            // _restaurantTableService.TUpdate(updateAboutDto);
            _restaurantTableService.TUpdate(restaurantTable);
            return Ok("It is Updated");
        }

        [HttpGet("GetRestaurantTable/{id}")]
        public IActionResult GetRestaurantTable(int id)
        {
            var value = _restaurantTableService.TGetByID(id);
            return Ok(value);
        }

        [HttpGet("RestaurantTableCount")]
        public IActionResult RestaurantTableCount()
        {
            var value = _restaurantTableService.TRestaurantTableCount();
            return Ok(value);
        }

    }
}
