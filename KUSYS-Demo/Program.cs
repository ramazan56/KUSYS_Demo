using KUSYS_Demo.Business;
using KUSYS_Demo.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddScoped<IStudentManager, StudentManager>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<KUSYSDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("KUSYSDb"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Student}/{action=StudentList}/{id?}");

app.Run();
