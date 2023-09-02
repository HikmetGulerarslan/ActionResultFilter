using ActionFilter.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

builder.Services.AddSingleton<LogFilters>();

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints => endpoints.MapDefaultControllerRoute());

app.Run();
