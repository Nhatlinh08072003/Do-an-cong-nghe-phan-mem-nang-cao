
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllers();
builder.Services.AddSingleton<EmailService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();
app.MapControllers();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Home",
    pattern: "/home",
    defaults: new { controller = "Home", action = "Home" }
);
app.MapControllerRoute(
    name: "VeChungToi",
    pattern: "/vechungtoi",
    defaults: new { controller = "Home", action = "VeChungToi" }
);
app.MapControllerRoute(
    name: "DuHoc",
    pattern: "/duhoc",
    defaults: new { controller = "Home", action = "DuHoc" }
);
app.MapControllerRoute(
    name: "LienHe",
    pattern: "/lienhe",
    defaults: new { controller = "Home", action = "LienHe" }
);
app.MapControllerRoute(
    name: "DichVu",
    pattern: "/dichvu",
    defaults: new { controller = "Home", action = "DichVu" }
);
app.MapControllerRoute(
    name: "QLTruong",
    pattern: "/qltruong",
    defaults: new { controller = "Admin", action = "QLTruong" }
);
app.MapControllerRoute(
    name: "QLTintuc",
    pattern: "/qltintuc",
    defaults: new { controller = "Admin", action = "QLTintuc" }
);
app.MapControllerRoute(
    name: "QLTuvan",
    pattern: "/qltuvan",
    defaults: new { controller = "Admin", action = "QLTuvan" }
);
app.MapControllerRoute(
    name: "QLTaikhoan",
    pattern: "/qltaikhoan",
    defaults: new { controller = "Admin", action = "QLTaikhoan" }
);
app.MapControllerRoute(
    name: "TQuan",
    pattern: "/tongquan",
    defaults: new { controller = "Admin", action = "TQuan" }
);
app.MapControllerRoute(
    name: "QLTaikhoan",
    pattern: "/qltaikhoan",
    defaults: new { controller = "Admin", action = "QLTaikhoan" }
);
app.MapControllerRoute(
    name: "Login",
    pattern: "/login",
    defaults: new { controller = "Account", action = "Login" }
);
app.MapControllerRoute(
    name: "Register",
    pattern: "/register",
    defaults: new { controller = "Account", action = "Register" }
);
app.Run();
