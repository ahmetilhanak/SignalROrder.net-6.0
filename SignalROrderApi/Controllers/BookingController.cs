using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.BookingDto;
using SignalR.EntityLayer.Entities;

namespace SignalROrderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetListAll();
            return Ok(values);
        }

        [HttpGet("GetBookingPaging")]
        public IActionResult GetBookingPaging()
        {
            var values = _bookingService.TGetListAll();
            var valuesPaged = PagingIt<Booking>.ListPaging(values,2,3);
            //return Ok(values);
            return Ok(valuesPaged);
        }

        [HttpGet("GetBookingPaging2/{countInterval}/{order}")]
        public IActionResult GetBookingPaging2(int countInterval,int order)
        {
            var values = _bookingService.TGetListAll();
            var valuesPaged = PagingIt<Booking>.ListPaging(values, countInterval, order);
            //return Ok(values);
            return Ok(valuesPaged);
        }

        [HttpGet("GetBookingPaging2")]
        public IActionResult GetBookingPaging3(int countInterval, int order)
        {
            var values = _bookingService.TGetListAll();
            var valuesPaged = PagingIt<Booking>.ListPaging(values, countInterval, order);
            //return Ok(values);
            return Ok(valuesPaged);
        }

        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            Booking booking = new Booking()
            {
                Date=createBookingDto.Date,
                Mail=createBookingDto.Mail,
                Name=createBookingDto.Name,
                Description=createBookingDto.Description,
                PersonCount=createBookingDto.PersonCount,
                Phone= createBookingDto.Phone
            };
            //_aboutSevice.TAdd(createAboutDto);
            _bookingService.TAdd(booking);
            return Ok("It is added on Booking");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetByID(id);
            _bookingService.TDelete(value);
            return Ok("Booking is deleted");
        }

        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            Booking booking = new Booking()
            {
                BookingID=updateBookingDto.BookingID,
                Date = updateBookingDto.Date,
                Mail = updateBookingDto.Mail,
                Name = updateBookingDto.Name,
                Description=updateBookingDto.Description,
                PersonCount = updateBookingDto.PersonCount,
                Phone = updateBookingDto.Phone
            };
            // _aboutSevice.TUpdate(updateAboutDto);
            _bookingService.TUpdate(booking);
            return Ok("It is Updated");
        }

        [HttpGet("GetBooking/{id}")]
        public IActionResult GetBooking(int id)
        {
            var value = _bookingService.TGetByID(id);
            return Ok(value);
        }

        [HttpGet("BookingStatusApproval/{id}")]
        public IActionResult BookingStatusApproval(int id)
        {
            _bookingService.TBookingStatusApproval(id);
             return Ok("Reservation Approved");
        }

        [HttpGet("BookingStatusCancellation/{id}")]
        public IActionResult BookingStatusCancellation(int id)
        {
            _bookingService.TBookingStatusCancellation(id);
            return Ok("Reservation Cancelled");
        }
    }
}
