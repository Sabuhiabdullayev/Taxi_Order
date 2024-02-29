using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Taxi.Dal.Concrete;
using Taxi.Dal.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ContextProject>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<ContextProject>();
builder.Services.AddControllersWithViews();
builder.Services.ConfigureApplicationCookie(opt =>
{
    opt.LoginPath = new PathString("/Login/SignIn/");
});
builder.Services.AddMvc(config =>
{

    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});
builder.Services.AddHttpClient();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error404");
}
app.UseStatusCodePagesWithReExecute("/Home/Error404", "?Code={0}");
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "Member",
      pattern: "{area:exists}/{controller=Order}/{action=MyOrder}/{id?}"
    );
});
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "Admin",
      pattern: "{area:exists}/{controller=Order}/{action=AllList}/{id?}"
    );
});
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Order}/{action=Mate}/{id?}");
});
app.Run();
