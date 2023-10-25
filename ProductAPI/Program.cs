using DAL;
using BAL;
using Microsoft.EntityFrameworkCore;
using DAL.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var ConnectionStrings = builder.Configuration.GetConnectionString("sqlconnect");
builder.Services.AddDbContext<MobileDbContext>(options => options.UseSqlServer(ConnectionStrings));
builder.Services.AddScoped<IMobileRepository, MobileRepository>();
builder.Services.AddScoped<MobileServices, MobileServices>();
builder.Services.AddScoped<ICartRepository, CartRepository>();
builder.Services.AddScoped<CartServices, CartServices>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();

app.Run();
