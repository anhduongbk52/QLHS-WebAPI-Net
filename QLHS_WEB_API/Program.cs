using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Model.Models;
using QLHS_WEB_API.Repositories;
using QLHS_WEB_API.Services;
using System.Text;

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

builder.Services.AddAuthentication().AddJwtBearer(o=>
{
    o.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
    {
        ValidIssuer = builder.Configuration["JwtConfig:Issuer"],
        ValidAudience = builder.Configuration["JwtConfig:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtConfig:Key"])),
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime=false,
        ValidateIssuerSigningKey = true
    };
});

var app = builder.Build();

//Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();


//app.MapUserEndpoint();
app.MapControllers();


app.Run();
