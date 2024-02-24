using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfNotificationDal : GenericRepository<Notification>, INotificationDal
    {
        public EfNotificationDal(SignalRContext context) : base(context)
        {
        }

        public List<Notification> GetAllNotificationsByStatusFalse()
        {
            using var context = new SignalRContext();

            return context.Notifications.Where(z => z.Status == false).ToList();
        }

        public int NotificationCountByStatusFalse()
        {
            using var context = new SignalRContext();

            return context.Notifications.Where(z=>z.Status==false).Count();
        }

        public void NotificationStatusChangetoFalse(int id)
        {
            using var context = new SignalRContext();

            var value = context.Notifications.Find(id);

            value.Status = false;

            context.SaveChanges();

        }

        public void NotificationStatusChangetoTrue(int id)
        {
            using var context = new SignalRContext();

            var value = context.Notifications.Find(id);

            value.Status = true;

            context.SaveChanges();

        }
    }
}
