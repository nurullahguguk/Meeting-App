var builder = WebApplication.CreateBuilder(args);

//MVC saşlonu kurar.
builder.Services.AddControllersWithViews();

//Projeyi çalıştırmayı sağlar.
var app = builder.Build();

//Controller/Action/Id?
app.MapDefaultControllerRoute();

app.Run();
