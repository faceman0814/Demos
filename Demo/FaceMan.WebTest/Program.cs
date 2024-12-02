using FaceMan.DynamicWebAPI.Extensions;
using FaceMan.EFTest;
using FaceMan.EntityFrameworkCore;
using FaceMan.EFTest.Extensions;
using FaceMan.DynamicWebAPI.Config;
using FaceMan.DynamicWebAPI;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var conifg = new SwaggerConfigParam()
{
    Title = "FaceMan API",
    Version = "v1",
    HttpMethods = builder.Configuration.GetSection("HttpMethodInfo").Get<List<HttpMethodConfigure>>()
};
builder.Services.AddDynamicApi(builder.Environment.WebRootPath, conifg);

builder.Services.RegisterDatabase();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseDynamicSwagger();

app.UseAuthorization();

app.MapStaticAssets();

app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
    //endpoints.MapControllerRoute(
    //name: "default",
    //pattern: "{controller=Home}/{action=Index}/{id?}");
    //endpoints.MapRazorPages();
    //Ìí¼Ó SignalR ¶Ëµã
    //endpoints.MapHub<SignalRTestHub>("/Hubs");

});
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}")
//    .WithStaticAssets();


app.Run();
