namespace Observer.Metrics;

public interface IChatMetric
{
    string Name { get; }

    string Format(long chatId);
}