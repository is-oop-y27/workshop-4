using System.Collections;
using Visitor.FileSystemStructure;
using Visitor.Visitors;

namespace Iterator.Iterators;

public class FileSystemDepthIterator : IFileSystemComponentVisitor, IEnumerator<IFileSystemComponent>
{
    private readonly Queue<IFileSystemComponent> _components;
    private readonly IFileSystemComponent _root;

    private IFileSystemComponent? _current;

    public FileSystemDepthIterator(IFileSystemComponent root)
    {
        _components = [];
        _root = root;

        root.Accept(this);
    }

    public IFileSystemComponent Current
        => _current ?? throw new InvalidOperationException("Current element is not set");

    object IEnumerator.Current => Current;

    public bool MoveNext()
    {
        if (_components.TryDequeue(out IFileSystemComponent? component) is false)
            return false;

        _current = component;
        return true;
    }

    public void Reset()
    {
        _components.Clear();
        _root.Accept(this);
    }

    public void Visit(FileFileSystemComponent component)
    {
        _components.Enqueue(component);
    }

    public void Visit(DirectoryFileSystemComponent component)
    {
        foreach (IFileSystemComponent innerComponent in component.Components)
        {
            innerComponent.Accept(this);
        }

        _components.Enqueue(component);
    }

    public void Dispose() { }
}