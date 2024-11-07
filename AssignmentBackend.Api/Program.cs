using AssigmentBackend.Business.Interfaces;
using AssigmentBackend.Business.Services;
using AssigmentBackend.Database;
using System;

namespace AssignmentBackend.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddSingleton<DbContext>();

            builder.Services.AddScoped<IRoomGetService, RoomGetService>();
            builder.Services.AddScoped<IRoomAvailabilityService, RoomAvailabilityService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
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
