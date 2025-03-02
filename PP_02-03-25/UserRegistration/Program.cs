using BusinessLayer.Service;
using BusinessLayer.Interface;
using RepositoryLayer.Service;
using RepositoryLayer.Interface;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Context;
using NLog.Web;
using NLog;

var logger = LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
logger.Info("Application Starting...");

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Logging.ClearProviders();
builder.Logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
builder.Host.UseNLog();

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IUserRegistrationBL , UserRegistrationBL>();
builder.Services.AddScoped<IUserRegistrationRL , UserRegistrationRL>();

//DbConnection
var connectionString = builder.Configuration.GetConnectionString("SqlConnection");
builder.Services.AddDbContext<UserRegistrationContext>(options => options.UseSqlServer(connectionString));

//Add Swagger to the container
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
