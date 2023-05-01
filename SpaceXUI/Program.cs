using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using SpaceXSL.SLMapper;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddAuthentication(AuthenticationOptions =>
{
    AuthenticationOptions.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
});
    //.AddJwtBearer();

WebApplication app = builder.Build();
// Middleware pipeline


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

//app.UseAuthorization();
//app.UseAuthentication();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");//.RequireAuthorization();

app.Run();
