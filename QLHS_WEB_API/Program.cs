using Microsoft.EntityFrameworkCore;
using Model.Models;
using QLHS_WEB_API.Repositories;
using QLHS_WEB_API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EemcdrContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyDBConnection"));
});
// Đăng ký IUserService
builder.Services.AddScoped<IUserService,UserService>();
// Đăng ký IUserRepository
builder.Services.AddScoped<IUserRepository, UserRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
