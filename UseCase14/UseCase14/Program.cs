using UseCase14;

var builder = WebApplication.CreateBuilder(args);

CreateHostBuilder(args).Build().Run();


var app = builder.Build();

app.Run();


IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.UseStartup<Startup>();
        });