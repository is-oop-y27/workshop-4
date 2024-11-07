using Observer.Metrics;

Console.WriteLine("Hello, World!");

static void WriteMetrics(long chatId, IEnumerable<IChatMetric> metrics)
{
    Console.WriteLine("Metrics: ");

    foreach (IChatMetric metric in metrics)
    {
        Console.WriteLine($"{metric.Name}: ");
        Console.WriteLine(metric.Format(chatId));
        Console.WriteLine();
    }
}