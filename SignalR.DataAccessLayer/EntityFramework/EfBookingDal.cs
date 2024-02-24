using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(SignalRContext context) : base(context)
        {
        }

        public void BookingStatusApproval(int id)
        {
            using var context = new SignalRContext();
            var bookingToApprove = context.Bookings.Find(id);
            bookingToApprove.Description = "Confirmed";
            context.SaveChanges();
        }

        public void BookingStatusCancellation(int id)
        {
            using var context = new SignalRContext();
            var bookingToCancel = context.Bookings.Find(id);
            bookingToCancel.Description = "Cancelled";
            context.SaveChanges();

        }
    }
}
