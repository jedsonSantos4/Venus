using Infrastructure;
using Microsoft.OpenApi.Models;
using System.Runtime.InteropServices;

var builder = WebApplication.CreateBuilder(args);

#region Conexao
builder.Services.AddTransient<DbSession>(_ =>
    new DbSession(builder.Configuration.GetConnectionString("MySqlConnection")));
#endregion

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
var infoSdk = RuntimeInformation.FrameworkDescription;
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1",
        new OpenApiInfo
        {
            Title = $"API Venus {infoSdk}",
            Description = $"API micro servico .NET 8 ({infoSdk})",
            Version = "v1",
            Contact = new OpenApiContact()
            {
                Name = "Jedson Santos",
                Url = new Uri("https://github.com/jedsonSantos4/Venus"),
            },
            License = new OpenApiLicense()
            {
                Name = "MIT",
                Url = new Uri("http://opensource.org/licenses/MIT"),
            }
        });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();

app.Run();