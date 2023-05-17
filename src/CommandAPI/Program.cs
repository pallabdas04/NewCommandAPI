using CommandAPI.Data;
namespace CommandAPI
{
    public class Program
    {
        // public static void Main(string[] args)
        // {
        //     var webBuilder = WebApplication.CreateBuilder(args);
        //     var startup = new Startup(webBuilder.Configuration);

        //     //Register services to enable the use of controllers throughout our application
        //     startup.ConfigureServices(webBuilder.Services);

        //     // builder.Services.AddControllers();
        //     // //DI
        //     // builder.Services.AddScoped<ICommandAPIRepo, MockCommandAPIRepo>();

        //     var app = webBuilder.Build();
        //     startup.Configure(app, app.Environment);

        //     // if (app.Environment.IsDevelopment())
        //     // {
        //     //     app.UseDeveloperExceptionPage();
        //     // }
        //     // app.UseRouting();
        //     // app.UseEndpoints(endpoints =>
        //     // {
        //     //     endpoints.MapControllers();
        //     // });
        //     //app.MapGet("/", () => "Hello World!");
            
        //     app.Run();
        // }

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}