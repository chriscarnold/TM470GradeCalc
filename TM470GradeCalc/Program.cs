using Microsoft.EntityFrameworkCore;
using TM470GradeCalc.Data; 

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

// config DbContext
builder.Services.AddDbContext<TM470Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // Default HSTS value 30 days
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();