var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllersWithViews();
}

var app = builder.Build();

{
    app.UseHttpsRedirection();
    //app.UseStaticFiles();
    //app.UseRouting();


    app.MapControllers();
    //app.MapControllerRoute(
    //    name: "default",
    //    pattern: "{controller}/{action=Index}/{id?}");

    //app.MapFallbackToFile("index.html"); ;

    app.Run();
}

