namespace Mindbox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=FigureController}/{action=Get}");

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}