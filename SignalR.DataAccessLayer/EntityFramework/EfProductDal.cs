using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(SignalRContext context) : base(context)
        {
        }

        public List<ResultProductWithCategoryDto> GetProductsWithCategories()
        {
            var context = new SignalRContext();
            var values = context.Products?.Include(x => x.Category).Select(y=>new ResultProductWithCategoryDto()
            {
                Description = y.Description,
                ImageUrl= y.ImageUrl,
                Price = y.Price,
                ProductID = y.ProductID,
                ProductName = y.ProductName,
                ProductStatus = y.ProductStatus,
                CategoryName= y.Category.CategoryName
            }).ToList();
            return values;
        }

        public int ProductCount()
        {
            using var context = new SignalRContext();
            return context.Products.Count();

        }

        //public List<ResultProductWithCategoryDto> deneme(string categoryname)
        //{
        //    var value = GetProductsWithCategories().Where(z => z.CategoryName == categoryname).ToList();
        //    return value;
        //}

        public int ProductCountByCategoryNameHamburger()
        {
            using var context = new SignalRContext();
            var hamburgerCategoryID = context.Categories.Where(z => z.CategoryName == "Hamburger").Select(w => w.CategoryID).FirstOrDefault();
            var value = context.Products.Where(z => z.CategoryID == hamburgerCategoryID);
            return value.Count();
        }

        public int ProductCountByCategoryNameDrink()
        {
            using var context = new SignalRContext();
            var drinkCategoryID = context.Categories.Where(z => z.CategoryName == "Drink").Select(w => w.CategoryID).FirstOrDefault();
            var value = context.Products.Where(z => z.CategoryID == drinkCategoryID);
            return value.Count();
        }

        public decimal ProductPriceAverage()
        {
            using var context = new SignalRContext();

            return context.Products.Average(z => z.Price);
        }

        public string ProductNameByMaxPrice()
        {
            using var context = new SignalRContext();
            return context.Products.Where(z => z.Price == (context.Products.Max(w => w.Price))).Select(y => y.ProductName).FirstOrDefault();
        }

        public string ProductNameByMinPrice()
        {
            using var context = new SignalRContext();
            return context.Products.Where(z => z.Price == (context.Products.Min(w => w.Price))).Select(y => y.ProductName).FirstOrDefault();

        }

        public decimal ProductAveragePriceOfHamburger()
        {
            using var context = new SignalRContext();
            var hamburgerCategoryID = context.Categories.Where(z => z.CategoryName == "Hamburger").Select(w => w.CategoryID).FirstOrDefault();
            var value = context.Products.Where(z => z.CategoryID == hamburgerCategoryID).Average(w=>w.Price);
            return value;
        }
    }
}
