using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SignalR.BusinessLayer.Abstract;
using SignalR.BusinessLayer.Concrete;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer
{
    public static class DependencyInjections
    {
        public static IServiceCollection BusinessInj(this IServiceCollection services)
        {

            services.AddScoped<IAboutSevice, AboutManager>();    // *** Added later
            services.AddScoped<IAboutDal, EfAboutDal>();         // *** Added later

            services.AddScoped<IBookingService, BookingManager>();    // *** Added later
            services.AddScoped<IBookingDal, EfBookingDal>();         // *** Added later

            services.AddScoped<ICategoryService, CategoryManager>();    // *** Added later
            services.AddScoped<ICategoryDal, EfCategoryDal>();         // *** Added later

            services.AddScoped<IContactService, ContactManager>();    // *** Added later
            services.AddScoped<IContactDal, EfContactDal>();         // *** Added later

            services.AddScoped<IDiscountService, DiscountManager>();    // *** Added later
            services.AddScoped<IDiscountDal, EfDiscountDal>();         // *** Added later

            services.AddScoped<IFeatureService, FeatureManager>();    // *** Added later
            services.AddScoped<IFeatureDal, EfFeatureDal>();         // *** Added later

            services.AddScoped<IProductService, ProductManager>();    // *** Added later
            services.AddScoped<IProductDal, EfProductDal>();         // *** Added later

            services.AddScoped<ISocialMediaSevice, SocialMediaManager>();    // *** Added later
            services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();         // *** Added later

            services.AddScoped<ITestimonialService, TestimonialManager>();    // *** Added later
            services.AddScoped<ITestimonialDal, EfTestimonialDal>();         // *** Added later

            services.AddScoped<IOrderService, OrderManager>();    // *** Added later
            services.AddScoped<IOrderDal, EfOrderDal>();         // *** Added later

            services.AddScoped<IOrderDetailService, OrderDetailManager>();    // *** Added later
            services.AddScoped<IOrderDetailDal, EfOrderDetailDal>();         // *** Added later

            services.AddScoped<IMoneyCaseService, MoneyCaseManager>();    // *** Added later
            services.AddScoped<IMoneyCaseDal, EfMoneyCaseDal>();         // *** Added later

            services.AddScoped<IRestaurantTableService, RestaurantTableManager>();    // *** Added later
            services.AddScoped<IRestaurantTableDal, EfRestaurantTableDal>();         // *** Added later

            services.AddScoped<ISliderService, SliderManager>();    // *** Added later
            services.AddScoped<ISliderDal, EfSliderDal>();         // *** Added later

            services.AddScoped<IBasketService, BasketManager>();    // *** Added later
            services.AddScoped<IBasketDal, EfBasketDal>();         // *** Added later

            services.AddScoped<INotificationService, NotificationManager>();    // *** Added later
            services.AddScoped<INotificationDal, EfNotificationDal>();         // *** Added later

            services.AddScoped<IMessageService, MessageManager>();    // *** Added later
            services.AddScoped<IMessageDal, EfMessageDal>();         // *** Added later

            return services;
        }
    }
}
