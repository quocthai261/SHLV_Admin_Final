using AdminWeb.Common.Utilities;
using AdminWeb.Dtos.Configuration;
using AdminWeb.Services;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Options;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddLocalization(o => { o.ResourcesPath = "Resources"; });
builder.Services.AddControllersWithViews()
                .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null)
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization();

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var cultures = new List<CultureInfo> {
        new CultureInfo("vi"),
        new CultureInfo("en")
                };
    options.DefaultRequestCulture = new RequestCulture("vi");
    options.SupportedCultures = cultures;
    options.SupportedUICultures = cultures;
});

var baseAddressApi = builder.Configuration.GetValue<string>("ConfigApi:BaseUrl");

builder.Services.AddScoped<IApiService, ApiService>();
builder.Services.AddScoped<IHttpClientService, HttpClientService>();
builder.Services.Configure<ApiConfig>(builder.Configuration.GetSection("ApiConfig"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

var options = app.Services.GetRequiredService<IOptions<RequestLocalizationOptions>>();
app.UseRequestLocalization(options.Value);

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
   name: "Admin",
   pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
