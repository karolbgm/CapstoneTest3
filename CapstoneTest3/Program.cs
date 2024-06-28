using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CapstoneTest3.Data;
namespace CapstoneTest3;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("AppDbContext") ?? throw new InvalidOperationException("Connection string 'AppDbContext' not found.")));

        // Add services to the container.

        builder.Services.AddControllers();

        builder.Services.AddCors();


        var app = builder.Build();



        // Configure the HTTP request pipeline.
       //origins - IP addresses Header - can be passed or not in this case and sends a token to the server to verify user/access

        app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());


        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
