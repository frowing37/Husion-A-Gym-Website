using Microsoft.AspNetCore.Identity;
using Gym_Entity.Concrete;
using Gym_Data.Concrete;
using Gym_Business.Abstract;
using Gym_Business.Concrete;
using Gym_Data.Abstract;
using Gym_Data.EntityFramework;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>().AddDefaultTokenProviders();

builder.Services.AddScoped<IAntrenorAdvisorService, AntrenorAdvisorManager>();
builder.Services.AddScoped<IAntrenorAdvisorDAL, EFAntrenorAdvisorDAL>();
builder.Services.AddScoped<IExercisesListService, ExercisesListManager>();
builder.Services.AddScoped<IExercisesListDAL, EFExercisesListDAL>();
builder.Services.AddScoped<IMessageService, MessageManager>();
builder.Services.AddScoped<IMessageDAL, EFMessageDAL>();
builder.Services.AddScoped<INutritionsListService, NutritionsListManager>();
builder.Services.AddScoped<INutritionsListDAL, EFNutritionsListDAL>();
builder.Services.AddScoped<ITargetService, TargetManager>();
builder.Services.AddScoped<ITargetDAL, EFTargetDAL>();

var app = builder.Build();

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
    pattern: "{controller=Home}/{action=Login}/{id?}");

//Identity Rollerinin eklenmesi
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var userManager = services.GetRequiredService<UserManager<AppUser>>();
    var roleManager = services.GetRequiredService<RoleManager<AppRole>>();
    var context = services.GetRequiredService<Context>();

    //Tanımlanan rollerin veri tabanına eklenmesi
    if (!context.Roles.Any())
    {
        var adminRole = new AppRole { Name = "Admin" };
        var antrenorRole = new AppRole { Name = "Antrenor" };
        var customerRole = new AppRole { Name = "Customer" };

        roleManager.CreateAsync(adminRole).Wait();
        roleManager.CreateAsync(antrenorRole).Wait();
        roleManager.CreateAsync(customerRole).Wait();
    }
}


app.Run();

