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
    public class EfOrderDal : GenericRepository<Order>, IOrderDal
    {
        public EfOrderDal(SignalRContext context) : base(context)
        {
        }

        public int ActiveOrderCount()
        {
            using var context = new SignalRContext();
            var value = context.Orders.Where(z => z.Description == "Costumer Sitting").Count();
            return value;
        }

        public decimal LastOrderPrice()
        {
            using var context = new SignalRContext();

            var value = context.Orders.OrderByDescending(z => z.OrderID).Take(1);
            return value.Select(w => w.TotalPrice).FirstOrDefault();


        }
            
        public decimal TodayTotalPrice()
        {
            //using var context = new SignalRContext();
            //var listOfOrdersToday = context.Orders.Where(z => z.OrderDate == DateTime.Parse(DateTime.Now.ToShortDateString())).ToList();
            //var value = listOfOrdersToday.Sum(y => y.TotalPrice).ToString();
            //return decimal.Parse(value);

            return 2;
        }

        public int TotalOrderCount()
        {
            using var context = new SignalRContext();
            var value = context.Orders.Count();

            return value;
        }
    }
}
