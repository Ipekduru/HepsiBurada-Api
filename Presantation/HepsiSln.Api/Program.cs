using HepsiSln.Persistence;
using HepsiSln.Application;
using HepsiSln.Mapper;
using HepsiSln.Application.Exceptions;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var env= builder.Environment;
//hepsiSln.Api nin pathi
builder.Configuration.SetBasePath(env.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: false) // appsettingsi her zamn bulur 
    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);// development a ozel appsetting


builder.Services.AddPresistence(builder.Configuration);
builder.Services.AddApplication();
builder.Services.AddCustomMapper();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//global exceptionhandler kullanýlmasý için 
app.ConfigureExceptionHandlingMiddleware();
app.UseAuthorization();

app.MapControllers();

app.Run();
