var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles(); // Tự động tìm index.html
app.UseStaticFiles();  // Cho phép phục vụ file trong wwwroot

app.Run();
