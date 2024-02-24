using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.NotificationDto;
using SignalR.EntityLayer.Entities;

namespace SignalROrderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationsController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpGet]
        public IActionResult NotificationList()
        {
            var values = _notificationService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateNotification(CreateNotificationDto createNotificationDto)
        {
            Notification notification = new Notification()
            {
                Icon = createNotificationDto.Icon,
                Type = createNotificationDto.Type,
                Description = createNotificationDto.Description,
                Status = false,
				Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
			};
            
            _notificationService.TAdd(notification);
            return Ok("It is added on Notification");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteNotification(int id)
        {
            var value = _notificationService.TGetByID(id);
            _notificationService.TDelete(value);
            return Ok("Notification is deleted");
        }

        [HttpPut]
        public IActionResult UpdateNotification(UpdateNotificationDto updateNotificationDto)
        {
            Notification notification = new Notification()
            {
                NotificationID = updateNotificationDto.NotificationID,
                Icon = updateNotificationDto.Icon,
                Type = updateNotificationDto.Type,
                Description = updateNotificationDto.Description,
				Status = updateNotificationDto.Status,
				Date = updateNotificationDto.Date
			};
            
            _notificationService.TUpdate(notification);
            return Ok("It is Updated");
        }

        [HttpGet("GetNotification/{id}")]
        public IActionResult GetNotification(int id)
        {
            var value = _notificationService.TGetByID(id);
            return Ok(value);
        }

        [HttpGet("NotificationCountByStatusFalse")]
        public IActionResult NotificationCountByStatusFalse()
        {
            var value = _notificationService.TNotificationCountByStatusFalse();
            return Ok(value);
        }

        [HttpGet("GetAllNotificationsByStatusFalse")]
        public IActionResult GetAllNotificationsByStatusFalse()
        {
            var value = _notificationService.TGetAllNotificationsByStatusFalse();
            return Ok(value);


        }

        [HttpGet("NotificationStatusChangetoTrue/{id}")]
        public IActionResult NotificationStatusChangetoTrue(int id)
        {
            _notificationService.TNotificationStatusChangetoTrue(id);

            return Ok("Status updated to true ");

        }

        [HttpGet("NotificationStatusChangetoFalse/{id}")]
        public IActionResult NotificationStatusChangetoFalse(int id)
        {
            _notificationService.TNotificationStatusChangetoFalse(id);

            return Ok("Status updated to false ");

        }
    }
}