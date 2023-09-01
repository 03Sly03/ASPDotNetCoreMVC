// builder => construire & configurer l'application
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build(); // => passe de "en construction" à application "prête"

// Ajout de Middlewares & configuration post build. L'ordre est important

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles(); // Pour utiliser ce qu'il y a dans le dossier "wwwroot". Si on le met pas, tout ce qu'il y a dans le dossier "wwwroot" n'est pas utilisé.

app.UseRouting(); // Pour utiliser les routes. Si on le met pas, on peut pas utiliser les routes

app.UseAuthorization(); // Authentication

// route par défaut (default) -> défini comment fonctionne la route. comment on accéde aux différentes actions
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// on peut créer différent pattern de route. ici si on fait /test on est rediriger vers la page privacy
app.MapControllerRoute(
    name: "customRoute",
    pattern: "test",
    new
    {
        Controller = "Home",
        Action = "Privacy"
    });

app.Run();
