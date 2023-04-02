using FilterLists.Api;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ReadOnlyDbContext>(options =>
    options.UseSqlServer("name=ConnectionStrings:FilterListsReadOnly"));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapGet("/lists",
    async (ReadOnlyDbContext dbContext, CancellationToken cancellationToken) =>
        await GetFilterLists.ExecuteAsync(dbContext, cancellationToken));

app.Run();