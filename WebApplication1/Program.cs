namespace WebApplication1
{
    public class Program
    {
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host
                .CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                        .UseStartup<Startup>();
                });
        }

        public static void Main(string[] args)
        {
            try
            {
                var host = CreateHostBuilder(args).Build();

                host.Run();
            }
            catch
            {
                Console.WriteLine("Unexpected error during startup");
            }
        }
    }
}
