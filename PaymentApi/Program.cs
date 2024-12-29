
using Application.Payments.Queries;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PaymentDetailContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));  

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();
 

    //var posts = app.MapGroup("/api/posts");
    //posts.MapGet("/getById/{id}", GetPostById)
    //    .WithName("GetPostById");

    //posts.MapPost("/create", CreatePost);

    //posts.MapGet("/getAll", GetAll);

    //posts.MapPut("/update/{id}", UpdatePost);

    //posts.MapDelete("/delete/{id}", DeletePost);

 

app.Run();
