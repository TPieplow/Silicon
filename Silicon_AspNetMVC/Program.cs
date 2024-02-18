namespace Silicon_AspNetMVC;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();

        var app = builder.Build();
        app.UseHsts();
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        //app.MapControllerRoute(
        //    name: "courses",
        //    pattern: "{controller=Courses}/{action=Courses}/{id?}");

        app.MapControllerRoute(
            name: "Error",
            pattern: "{*url}",
            defaults: new { controller = "Error", action = "PageNotFound" });

        app.Run();
    }
}
