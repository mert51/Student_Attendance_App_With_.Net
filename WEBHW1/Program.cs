var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(
name:"default" , pattern:"BeforeSign/{controller=BeforeSign}/{action=Before}/{id?}");


app.MapControllerRoute(
name: "default", pattern: "AfterSign/{controller=AfterSign}/{action=After}/{id?}");

app.MapControllerRoute(
name: "default", pattern: "AllStudents/{controller=AllStudents}/{action=AllStudents}/{id?}");

app.MapControllerRoute(
name: "default", pattern: "/{controller=HomePage}/{action=Home}/{id?}");

app.MapControllerRoute(
name: "default", pattern: "AttendanceInfo/{controller=AllStudents}/{action=Attendance}/{id?}");

app.MapDefaultControllerRoute();

app.Run();
