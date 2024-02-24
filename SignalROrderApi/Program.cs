using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SignalR.BusinessLayer;
using SignalR.BusinessLayer.Abstract;
using SignalR.BusinessLayer.Concrete;
using SignalR.DataAccessLayer;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.EntityFramework;
using SignalROrderApi.Hubs;
using System.Reflection;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();

builder.Services.AddCors(opt =>          // *** Added later for S?GNALR Configuration
{
    opt.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyHeader()
        .AllowAnyMethod()
        .SetIsOriginAllowed((host) => true)
        .AllowCredentials();
    });
});

builder.Services.AddSignalR();

builder.Services.AddDbContext<SignalRContext>();           // *** Added later
// !!  builder.Services.SignalRDbConnectionStringInj(configuration);

//var connectionString = builder.Configuration.GetConnectionString("SignalRDatabase");
//var connectionString = builder.Configuration.GetSection("ConnectionStrings")["SignalRDatabase"];
//builder.Services.AddDbContext<SignalRContext>(options => options.UseSqlServer(connectionString));



builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());     // *** Added later

builder.Services.BusinessInj(); //

builder.Services.AddControllersWithViews()                      // *** Added later  , configuration for INCLUDE method using
         .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler =
         ReferenceHandler.IgnoreCycles);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapHub<SignalRHub>("/signalrhub");

app.Run();
