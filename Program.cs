var builder = WebApplication.CreateBuilder(args);

// 1. Configuramos el proyecto para que use Controladores y Vistas (MVC)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// 2. Permitimos el uso de archivos estáticos (por si usas CSS o JS propio)
app.UseStaticFiles();

app.UseRouting();

// 3. Definimos la ruta de inicio. 
// Al abrir el navegador, cargará automáticamente el Controlador "Anime" y su acción "Index"
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Anime}/{action=Index}/{id?}");
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.Run();