using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using StoreApp.Data;
using StoreApp.Repository.Services;
using StoreApp.Repository.Services.IRepository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddDbContext<PointOfSaleContext>(options =>
             options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//builder.Services.AddMvc().AddJsonOptions(options =>
//{
//    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
//});

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

app.UseCors(
        options => options.WithOrigins("http://localhost:4200").AllowAnyHeader()
                                .AllowAnyMethod()
    );
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
