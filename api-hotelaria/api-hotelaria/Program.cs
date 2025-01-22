
using api_hotelaria.Config;
using api_hotelaria.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace api_hotelaria
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddEntityFrameworkNpgsql()
            .AddDbContext<Context>(Options =>
            {
                Options.UseNpgsql(builder.Configuration.GetConnectionString("ConnectionString"));
                AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            });


            builder.Services.GerenciadorDeServicos();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
