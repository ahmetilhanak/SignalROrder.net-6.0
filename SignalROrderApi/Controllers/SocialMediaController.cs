using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.SocialMediaDto;
using SignalR.EntityLayer.Entities;

namespace SignalROrderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaSevice _socialMediaSevice;
        private readonly IMapper _mapper;

        public SocialMediaController(ISocialMediaSevice socialMediaSevice, IMapper mapper)
        {
            _socialMediaSevice = socialMediaSevice;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult SocialMediaList()
        {
            var value = _mapper.Map<List<ResultSocialMediaDto>>(_socialMediaSevice.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            _socialMediaSevice.TAdd(new SocialMedia()
            {
                Icon = createSocialMediaDto.Icon,
                Title = createSocialMediaDto.Title,
                Url = createSocialMediaDto.Url,
            });
            return Ok("SocialMedia added");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _socialMediaSevice.TGetByID(id);
            _socialMediaSevice.TDelete(value);
            return Ok("SocialMedia is deleted");
        }


        [HttpGet("GetSocialMedia/{id}")]
        public IActionResult GetSocialMedia(int id)
        {
            var value = _mapper.Map<GetSocialMediaDto>(_socialMediaSevice.TGetByID(id));
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            _socialMediaSevice.TUpdate(new SocialMedia()
            {
                SocialMediaID=updateSocialMediaDto.SocialMediaID,
                Icon = updateSocialMediaDto.Icon,
                Title = updateSocialMediaDto.Title,
                Url = updateSocialMediaDto.Url,
            });
            return Ok("It is Updated");
        }
    }
}
