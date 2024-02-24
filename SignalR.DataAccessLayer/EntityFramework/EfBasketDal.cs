using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.DtoLayer.BasketDto;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfBasketDal : GenericRepository<Basket>, IBasketDal
    {
        public EfBasketDal(SignalRContext context) : base(context)
        {
        }

        public List<Basket> GetBasketByRestaurantTableNumber(int id)
        {
            using var context = new SignalRContext();

            // var values= context.Baskets.Where(z => z.RestaurantTableID == id).ToList();
            var values = context.Baskets.Include(z => z.Product).Where(q => q.RestaurantTableID == id).ToList();

            return values;
        }

        public List<Basket> GetBasketByRestaurantTableNumberWithProductName(string productName)
        {
            using var context = new SignalRContext();
            var productID = context.Products.Where(z => z.ProductName == productName).Select(w=>w.ProductID).FirstOrDefault();
            var values = context.Baskets.Where(z => z.ProductID==productID).ToList();
            return values;
        }

        public List<ResultBasketWithProductDto> GetBasketWithProductNameByRestaurantTableNumber(int id)
        {
            using var context = new SignalRContext();           
            var values=context.Baskets.Include(z=>z.Product).Where(q => q.RestaurantTableID == id).ToList();

            var dtoList = values.Select(basket => new ResultBasketWithProductDto
            {
                BasketID=basket.BasketID,
                Count=basket.Count,
                Price=basket.Price,
                ProductID=basket.ProductID,
                RestaurantTableID=basket.RestaurantTableID,
                TotalPrice=basket.TotalPrice,
                ProductName=basket.Product.ProductName
            }).ToList();
            //var values=context.Baskets.Include(z=>z.Product).Where(q => q.RestaurantTableID == id).ToList();
            return dtoList;

        }
    }
}
