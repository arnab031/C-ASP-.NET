using WebApp01;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSession(options => options.IdleTimeout = TimeSpan.FromSeconds(180));

builder.Services.AddSingleton<IEmployeeRepository, TechnicalEmployeesRepository>();
//builder.Services.AddSingleton<IEmployeeRepository, HrEmployeesRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseHttpLogging();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.UseSession();

app.Run();

