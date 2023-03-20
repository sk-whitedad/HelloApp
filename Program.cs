using HelloApp.Data.interfaces;
using HelloApp.Data.mocks;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IAllCars, MockCars>();
builder.Services.AddTransient<ICarsCategory, MockCategory>();
builder.Services.AddMvc(mvcOtions =>
{
    mvcOtions.EnableEndpointRouting = false;
});

var app = builder.Build();
app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseMvcWithDefaultRoute();
app.MapGet("/", () => "Hello World!");
app.Run();