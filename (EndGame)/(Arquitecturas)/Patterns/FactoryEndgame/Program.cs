/*
  @title        FACTORY PATTERN IN C# WITH DEPENDENCY INJECTION
  @description  This is an EndGame example of the Factory Pattern in C# with
                Dependency Injection
  @author       Gerardo Tordoya
  @date         2022-10-07
  @credits      https://youtu.be/2PXAfSfvRKY
*/


using FactoryEndgame.Data;
using FactoryEndgame.Samples;
using FactoryEndgame.Factories;


// ─── RUN ─────────────────────────────────────────────────────────────────────

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddAbstractFactory<ISample1, Sample1>();
builder.Services.AddAbstractFactory<ISample2, Sample2>();
builder.Services.AddGenericClassWithDataFactory();
builder.Services.AddVehicleFactory();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for
    // production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
