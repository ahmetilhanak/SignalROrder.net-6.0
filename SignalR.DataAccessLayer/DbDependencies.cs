using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SignalR.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer
{
    public static class DbDependencies
    {
        public static IServiceCollection SignalRDbConnectionStringInj(this IServiceCollection services,IConfiguration configuration)
        {
            

            services.AddDbContext<SignalRContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SignalRDatabase"));

            });

            return services;
        }
       
    }

    



}
