using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalROrderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutSevice _aboutSevice;

        public AboutController(IAboutSevice aboutSevice)
        {
            _aboutSevice = aboutSevice;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutSevice.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            About about = new About()
            {
                Title = createAboutDto.Title,
                Description = createAboutDto.Description,
                ImageUrl = createAboutDto.ImageUrl
            };
            //_aboutSevice.TAdd(createAboutDto);
            _aboutSevice.TAdd(about);
            return Ok("It is added on About");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var value = _aboutSevice.TGetByID(id);
            _aboutSevice.TDelete(value);
            return Ok("About is deleted");
        }

        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            About about = new About()
            {
                AboutID=updateAboutDto.AboutID,
                Title = updateAboutDto.Title,
                Description = updateAboutDto.Description,
                ImageUrl = updateAboutDto.ImageUrl
            };
           // _aboutSevice.TUpdate(updateAboutDto);
            _aboutSevice.TUpdate(about);
            return Ok("It is Updated");
        }

        [HttpGet("GetAbout/{id}")]
        public IActionResult GetAbout(int id)
        {
            var value = _aboutSevice.TGetByID(id);
            return Ok(value);
        }


    }
}
