global using Data;
global using FAZ.Components;
global using Microsoft.EntityFrameworkCore;
global using Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddBlazorBootstrap();

var ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
if (string.IsNullOrEmpty(ConnectionString)){
    throw new Exception("Connection String Is Invalid");
}
builder.Services.AddDbContext<ApplicationDatabaseContext>(
    options => options.UseMySql(ConnectionString, ServerVersion.AutoDetect(ConnectionString))
);

builder.Services.AddScoped<TeamServices>();
builder.Services.AddScoped<RefereeServices>();
builder.Services.AddScoped<PlayerServices>();
builder.Services.AddScoped<MatchServices>();
builder.Services.AddScoped<SubstitutionServices>();
builder.Services.AddScoped<MatchParticipationServices>();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
