using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LAB2_gaftone_delia.Data;
using Microsoft.AspNetCore.Identity;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<LAB2_gaftone_deliaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LAB2_gaftone_deliaContext") ?? throw new InvalidOperationException("Connection string 'LAB2_gaftone_deliaContext' not found.")));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<LibraryIdentityContext>();

builder.Services.AddDbContext<LibraryIdentityContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("LAB2_gaftone_deliaContext") ?? throw new InvalidOperationException("Connectionstring 'LAB2_gaftone_deliaContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();

app.Run();
