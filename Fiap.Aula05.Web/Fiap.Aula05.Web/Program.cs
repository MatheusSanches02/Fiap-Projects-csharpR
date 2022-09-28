using Fiap.Aula05.Web.Models.Persistencia;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Obter a string de conexão do banco de dados
var connection = builder.Configuration.GetConnectionString("conexao");

// Configurar o serviço de DbContext (Injeção de Dependência)
builder.Services.AddDbContext<DimDimContext>(o => o.UseSqlServer(connection));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
