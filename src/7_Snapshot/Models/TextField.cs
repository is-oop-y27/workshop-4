namespace Snapshot.Models;

public class TextField
{
    public string Value { get; private set; } = string.Empty;

    public void UpdateValue(string value)
    {
        Value = value;
    }
}