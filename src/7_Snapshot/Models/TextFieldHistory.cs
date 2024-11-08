namespace Snapshot.Models;

public class TextFieldHistory
{
    private readonly TextField _field;
    private readonly List<TextFieldSnapshot> _snapshots;

    public TextFieldHistory(TextField field)
    {
        _field = field;
        _snapshots = [];
    }

    public string Value => _field.Value;

    public IEnumerable<TextFieldSnapshot> History => _snapshots;

    public TextFieldSnapshot UpdateValue(string value)
    {
        TextFieldSnapshot snapshot = _field.CreateSnapshot();
        _snapshots.Add(snapshot);

        _field.UpdateValue(value);

        return snapshot;
    }

    public void Restore(TextFieldSnapshot snapshot)
    {
        if (_snapshots.Contains(snapshot) is false)
            throw new InvalidOperationException();

        _field.RestoreSnapshot(snapshot);
    }
}