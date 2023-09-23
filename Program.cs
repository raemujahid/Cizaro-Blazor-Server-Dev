using Blazored.LocalStorage;
using Blazored.Toast;
using Cizaro_Blazor_Server.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddBlazoredLocalStorage();
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazoredToast();

builder.Services.AddSingleton<WeatherForecastService>();
var configVal = builder.Configuration.GetValue<string>("AppSettings:CizaroApiBaseUrl");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(configVal) });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
