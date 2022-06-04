using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SparkFishChallenge;

Host.CreateDefaultBuilder()
    .ConfigureServices((context, services) =>
        {
            services.AddHostedService<SparkFish>();
            services.AddTransient<ISharedClass,SharedClass>();
        })
    .Build()
    .Run();
