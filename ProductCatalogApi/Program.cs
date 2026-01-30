
using Microsoft.EntityFrameworkCore;
using ProductCatalogApi.Data;

namespace ProductCatalogApi
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            //Servicio Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();
            //Usa swagger fuera del modo de desarrollo
            app.UseSwagger();
            app.UseSwaggerUI();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
