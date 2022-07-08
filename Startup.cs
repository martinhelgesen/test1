public class Startup 
{
    public IConfigurationRoot Configuration { get; set; }

    public Startup(IWebHostEnvironment env)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        Configuration = builder.Build();
    }
}