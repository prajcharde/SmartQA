using SmartQA.Application.Interfaces;
using SmartQA.Application.Features;
using SmartQA.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IDocumentRepository, InMemoryDocumentRepository>(); // will changed it later to add scoped
builder.Services.AddScoped<UploadDocumentHandler>();

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapPost("/documents", async (UploadDocumentRequest request, UploadDocumentHandler handler) =>
{
    var id = await handler.HandleAsync(request.FileName, request.Content);
    return Results.Created($"/documents/{id}", new { id });
});

app.Run();

public record UploadDocumentRequest(string FileName, string Content);