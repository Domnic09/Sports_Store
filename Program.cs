using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Taboada_SportsStore.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<StoreDBContext>(opts => { 

    opts.UseSqlServer(
    builder.Configuration["ConnectionStrings:SportsStoreConnection"]);

});



builder.Services.AddScoped<IStoreRepository, EFStoreRepository>();


var app = builder.Build();

app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapDefaultControllerRoute(); 

app.Run();
