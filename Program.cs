using WeatherServiceInterface;
using Services;

namespace CRUDExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddTransient<IWeatherService, CityService>();
            var app = builder.Build();
            app.UseStaticFiles();
            app.UseRouting();
            app.MapControllers();

            //app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
