namespace WebAppProject1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            // проверка на процесс разработки
            if (!app.Environment.IsDevelopment())
            {
                // ошибка при открытии несуществующих страниц
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            
            app.UseHttpsRedirection(); // переадресации
            app.UseStaticFiles(); // все файлы wwwroot

            app.UseRouting();

            app.UseAuthorization();

            // отслеживание url-адресов
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"); // (контроллер/метод/)

            app.Run();
        }
    }
}
