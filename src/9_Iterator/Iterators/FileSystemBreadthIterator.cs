using System.Collections;
using Visitor.FileSystemStructure;
using Visitor.Visitors;

namespace Iterator.Iterators;

public class FileSystemBreadthIterator : IFileSystemComponentVisitor, IEnumerator<IFileSystemComponent>
{
    private readonly Queue<IFileSystemComponent> _components;
    private readonly IFileSystemComponent _root;

    private IFileSystemComponent? _current;

    public FileSystemBreadthIterator(IFileSystemComponent root)
    {
        _components = [];
        _root = root;

        _components.Enqueue(root);
    }

    public IFileSystemComponent Current
        => _current ?? throw new InvalidOperationException("Current element is not set");

    object IEnumerator.Current => Current;

    public bool MoveNext()
    {
        if (_components.TryDequeue(out IFileSystemComponent? component) is false)
            return false;

        _current = component;
        component.Accept(this);

        return true;
    }

    public void Reset()
    {
        _components.Clear();
        _components.Enqueue(_root);
    }

    public void Visit(FileFileSystemComponent component) { }

    public void Visit(DirectoryFileSystemComponent component)
    {
        foreach (IFileSystemComponent innerComponent in component.Components)
        {
            _components.Enqueue(innerComponent);
        }
    }

    public void Dispose() { }
}