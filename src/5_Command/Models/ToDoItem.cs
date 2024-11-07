using System.Reactive.Subjects;

namespace Command.Models;

public class ToDoItem
{
    private readonly ReplaySubject<string> _nameSubject = new(1);

    public ToDoItem(string name)
    {
        Name = name;
        _nameSubject.OnNext(name);
    }

    public string Name { get; private set; }

    public IObservable<string> NameObservable => _nameSubject;

    public ToDoItem Clone()
    {
        return new ToDoItem(Name);
    }

    public void SetName(string value)
    {
        Name = value;
        _nameSubject.OnNext(Name);
    }
}