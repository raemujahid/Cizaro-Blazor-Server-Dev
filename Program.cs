using Blazored.LocalStorage;
using Blazored.Toast;
using Cizaro_Blazor_Server.Data;
using Cizaro_Blazor_Server.Services;
using Cizaro_Blazor_Server.Services.Interfaces;
using DevExpress.Blazor;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddBlazoredLocalStorage();
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazoredToast();

builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IHttpService, HttpService>();

builder.Services.AddSingleton<AppState>();
var configVal = builder.Configuration.GetValue<string>("AppSettings:CizaroApiBaseUrl");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(configVal) });
builder.WebHost.UseWebRoot("wwwroot");
builder.WebHost.UseStaticWebAssets();
/* ... */

builder.Services.AddDevExpressBlazor(configure => configure.BootstrapVersion = BootstrapVersion.v5);
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
