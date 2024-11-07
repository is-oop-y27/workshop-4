namespace Snapshot.Models;

public class TextFieldHistory
{
    private readonly TextField _field;

    public TextFieldHistory(TextField field)
    {
        _field = field;
    }

    public void UpdateValue(string value)
    {
        _field.UpdateValue(value);
    }

    public void Restore() { }
}