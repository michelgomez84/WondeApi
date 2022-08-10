using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using WebMvc.Helper;
using WebMvc.Helpers;
using WondeApiServices.IServices;
using WondeApiServices.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//add your service registrations
builder.Services.AddSingleton<ISchoolService, SchoolService>();
builder.Services.AddSingleton<IClasessService, ClasessService>();
builder.Services.AddSingleton<IEmployesService, EmployesService>();
builder.Services.AddSingleton<ILessonService, LessonService>();
builder.Services.AddSingleton<IPeriodService, PeriodService>();
builder.Services.AddSingleton<IRoomService, RoomService>();
builder.Services.AddSingleton<IStudentService, StudentService>();

builder.Services.AddScoped<IJwtUtils, JwtUtils>();

//builder.AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, configureOptions);

builder.Services.AddCors();
builder.Services.AddControllers();

var app = builder.Build();// configure HTTP request pipeline

// global cors policy
app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
// custom jwt auth middleware
app.UseMiddleware<JwtMiddleware>();
app.MapControllers();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
