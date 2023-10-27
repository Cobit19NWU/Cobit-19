using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using Microsoft.AspNetCore.Identity;
using Cobit_19.Data;
using Cobit_19.Data.Models;
using Microsoft.Extensions.DependencyInjection;
using Cobit_19.Business.Audits;
using Syncfusion.Blazor;
using Cobit_19.Business.Admin;
using Cobit_19.Business.FocusAreas;
using Cobit_19.Business.ObjectiveAudits;
using Blazored.Toast;
using Cobit_19.Business.Reports;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options => {

    var env = Environment.GetEnvironmentVariable("RUNTIME");

    if (env != "Production")
    {
        // Use development connection string
        options.UseSqlServer(builder.Configuration.GetConnectionString("DevelopmentConnection"), sqlServerOptions =>
        {
            sqlServerOptions.CommandTimeout(1000); // Set the command timeout to 120 seconds (adjust as needed)
        });
    }
    else
    {
        // Use production connection string
        options.UseSqlServer(builder.Configuration.GetConnectionString("ProductionConnection"), sqlServerOptions =>
        {
            sqlServerOptions.CommandTimeout(1000); // Set the command timeout to 120 seconds (adjust as needed)
        });
    }

    options.EnableSensitiveDataLogging();
});

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>();
builder.Services.AddAuthentication("Identity.Application")
    .AddCookie();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddSyncfusionBlazor();
builder.Services.AddBlazoredToast();

builder.Services.AddScoped<UserManagementProvider>();
builder.Services.AddScoped<AuditProvider>();
builder.Services.AddScoped<FocusAreaProvider>();
builder.Services.AddScoped<ObjectiveAuditProvider>();
builder.Services.AddScoped<ReportProvider>();

builder.Services.AddSignalR(e => {
    e.MaximumReceiveMessageSize = 102400000;
});

var syncfusionKey = Environment.GetEnvironmentVariable("SYNCFUSION_KEY");
var app = builder.Build();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(syncfusionKey);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<AppDbContext>();
    context.Database.Migrate();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.UseAuthentication();;

app.Run();
