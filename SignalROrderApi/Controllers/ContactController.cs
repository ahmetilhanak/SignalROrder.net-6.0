﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ContactDto;
using SignalR.EntityLayer.Entities;

namespace SignalROrderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult ContactList()
        {
            var value = _mapper.Map<List<ResultContactDto>>(_contactService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            _contactService.TAdd(new Contact()
            {
                FooterDescription=createContactDto.FooterDescription,
                Location=createContactDto.Location,
                Mail=createContactDto.Mail,
                Phone=createContactDto.Phone,
                FooterTitle=createContactDto.FooterTitle,
                Opendays=createContactDto.Opendays,
                OpenDaysDescription=createContactDto.OpenDaysDescription,
                OpenHours = createContactDto.OpenHours
			});
            return Ok("Contact added");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetByID(id);
            _contactService.TDelete(value);
            return Ok("Contact is deleted");
        }


        [HttpGet("GetContact/{id}")]
        public IActionResult GetContact(int id)
        {
            var value = _mapper.Map<GetContactDto>(_contactService.TGetByID(id));
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto )
        {
            _contactService.TUpdate(new Contact()
            {   
                ContactID=updateContactDto.ContactID,
                FooterDescription = updateContactDto.FooterDescription,
                Location = updateContactDto.Location,
                Mail = updateContactDto.Mail,
                Phone = updateContactDto.Phone,
				FooterTitle = updateContactDto.FooterTitle,
				Opendays = updateContactDto.Opendays,
				OpenDaysDescription = updateContactDto.OpenDaysDescription,
				OpenHours = updateContactDto.OpenHours
			});
            return Ok("It is Updated");
        }
    }
}