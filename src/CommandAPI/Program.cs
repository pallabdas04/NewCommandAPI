using CommandAPI.Data;
namespace CommandAPI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //Register services to enable the use of controllers throughout our application
            builder.Services.AddControllers();
            //DI
            builder.Services.AddScoped<ICommandAPIRepo, MockCommandAPIRepo>();

            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            //app.MapGet("/", () => "Hello World!");
            
            app.Run();
        }
    }
}