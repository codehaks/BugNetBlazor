using BugNet.Application.Contracts;
using BugNet.Application.Services;
using BugNet.Infrastructure.Data;
using BugNet.Web.Components;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<BugDbContext>(options =>
{
    options.UseSqlite(builder.Configuration["Database"]);
    options.LogTo(Console.WriteLine, LogLevel.Information);
});

builder.Services.AddScoped<IBugService, BugService>();

builder.Services.AddRazorComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>();

app.Run();
