var builder = WebApplication.CreateBuilder(args);

// Добавление сервисов MVC
builder.Services.AddControllers();

// Регистрация ваших кастомных сервисов
builder.Services.AddScoped<EmployeeService>();
builder.Services.AddScoped<MunicipalEducationService>();

var app = builder.Build();

app.UseRouting();
app.MapControllers();

app.Run();