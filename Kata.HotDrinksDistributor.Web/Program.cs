using Kata.HotDrinks.DataAccess.Repositories;
using Kata.HotDrinks.Domain.Ports;
using Kata.HotDrinks.Domain.Services;
using Kata.HotDrinksDistributor.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<HotDrinksContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("HotDrinksDb")));

builder.Services.AddTransient<IIngredientRepository, IngredientRepository>();
builder.Services.AddTransient<IRecetteRepository, RecetteRepository>();
builder.Services.AddScoped<IIngredientService, IngredientService>();
builder.Services.AddScoped<IRecetteService, RecetteService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
