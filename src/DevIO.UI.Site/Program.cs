var builder = WebApplication.CreateBuilder(args);

#region " Configurando serviços no container "

// Adicionando MVC no pipeline
builder.Services.AddControllersWithViews();

var app = builder.Build();

#endregion

# region " Configurando o resquest dos serviços no pipeline "

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();

// Adicionando suporte a rotas
app.UseRouting();

// Rota padrão
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

app.Run();

#endregion