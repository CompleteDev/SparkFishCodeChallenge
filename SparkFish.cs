using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SparkFishChallenge;

internal class SparkFish : IHostedService
{
    private readonly ISharedClass _shared;
    public SparkFish(ISharedClass sharedClass)
    {
        _shared = sharedClass;
    }
    
    public async Task StartAsync(CancellationToken cancellationToken)
    {

        int LowerNumber = _shared.GetFirstNumber();

        Console.WriteLine($"Your Low number is { LowerNumber }");

        int HighNumber = _shared.GetSecondNumber(LowerNumber);

        Console.WriteLine($"Your 2nd Number is { HighNumber }");

        int TotalPositions = _shared.GetTotalNumberOfPositions(LowerNumber,HighNumber);

        _shared.GetSelectedPosition(TotalPositions, LowerNumber, HighNumber);


        Console.ReadLine();
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

}