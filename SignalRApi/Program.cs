
using SignalRApi.Hubs;
using SignalRBusinessLayer.Abstract;
using SignalRBusinessLayer.Concrete;
using SignalREntityLayer.Entities;
using SignaRDataAccessLayer.Abstract;
using SignaRDataAccessLayer.Concrete;
using SignaRDataAccessLayer.EntityFramework;
using System.Reflection;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(opt =>
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


builder.Services.AddDbContext<SignalRContext>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IAboutDal, EFAboutDal>();

builder.Services.AddScoped<IBookingService, BookingManager>();
builder.Services.AddScoped<IBookingDal,EFBookingDal>();

builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ICategoryDal, EFCategoryDal    >();

builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IContactDal, EFContactDal>();

builder.Services.AddScoped<IFeatureService, FeatureManager>();
builder.Services.AddScoped<IFeatureDal, EFFeatureDal >();

builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IProductDal, EFProductDal>();

builder.Services.AddScoped<IDiscountService,DiscountManager>();
builder.Services.AddScoped<IDiscountDal, EFDiscountDal>();

builder.Services.AddScoped<ISocialMediaService, SocialMediaManager>();
builder.Services.AddScoped<ISocialMediaDal, EFSocialMediaDal>();

builder.Services.AddScoped<ITestiMonialService, TestiMonialManager>();
builder.Services.AddScoped<ITestiMonialDal, EFTestiMonialDal>();

builder.Services.AddScoped<IOrderService, OrderManager>();
builder.Services.AddScoped<IOrderDal, EFOrderDal>();

builder.Services.AddScoped<IOrderDetailService, OrderDetailManager>();
builder.Services.AddScoped<IOrderDetailDal, EFOrderDetailDal>();

builder.Services.AddScoped<IMoneyCaseService, MoneyCaseManager>();
builder.Services.AddScoped<IMoneyCaseDal, EfMoneyCaseDal>();

builder.Services.AddScoped<IMenuTableService, MenuTableManager>();
builder.Services.AddScoped<IMenuTableDal, EFMenuTableDal>();

builder.Services.AddScoped<ISliderService, SliderManager>();
builder.Services.AddScoped<ISliderDal, EFSliderDal>();

builder.Services.AddScoped<IBasketService, BasketManager>();
builder.Services.AddScoped<IBasketDal, EfBasketDal>();

builder.Services.AddScoped<INotificationService, NotificationManager>();
builder.Services.AddScoped<INotificationDal, EFNotificationDal>();

builder.Services.AddControllersWithViews()
	.AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler =ReferenceHandler.IgnoreCycles);
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
