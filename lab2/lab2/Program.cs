using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using Lab2.DAL.Models;
using lab2.DAL.Reposatory.Tickets;
using lab2.BL.Managers;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

////var connectionString = builder.Configuration.GetConnectionString("lab2");
//builder.Services.AddDbContext<LabContext>(
//    Options => { Options.UseSqlServer(builder.Configuration.GetConnectionString("lab2")); });

var connectionString = builder.Configuration.GetConnectionString("Lab2");
builder.Services.AddDbContext<LabContext>(
    options => options.UseSqlServer(connectionString));
builder.Services.AddAutoMapper(x => x.AddProfile(new DomainProfile()));

#region addscope of repo
builder.Services.AddScoped<ITicket, TicketRepo>();
builder.Services.AddScoped<ITicketManager, TicketManager>();
#endregion


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
