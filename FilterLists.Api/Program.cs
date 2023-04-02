using FilterLists.Api;
using FilterLists.Api.Queries.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<QueryDbContext>(options =>
    options.UseSqlServer("name=ConnectionStrings:FilterListsReadOnly"));
builder.Services.AddScoped<IQueryContext, QueryContext>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapRoutes();

app.Run();