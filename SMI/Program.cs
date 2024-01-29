using MongoDB.Driver;
using SMI.Components;
using SMI.DataAccess.Services;
using SMI.DataAccess.Services.Interfaces;
using SMI.Routes;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var client = new MongoClient(Environment.GetEnvironmentVariable("CONNECTION_STRING"));
var db = client.GetDatabase("SolveMyIssue");
builder.Services.AddSingleton(db);


builder.Services.AddSingleton<IIssueRepository, IssueRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
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

IssueRoutes.MapIssueEndpoints(app);

app.Run();