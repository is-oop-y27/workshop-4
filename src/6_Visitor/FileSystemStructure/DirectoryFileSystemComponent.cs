namespace Visitor.FileSystemStructure;

public class DirectoryFileSystemComponent : IFileSystemComponent
{
    public DirectoryFileSystemComponent(string name, IReadOnlyCollection<IFileSystemComponent> components)
    {
        Name = name;
        Components = components;
    }

    public string Name { get; }
    public IReadOnlyCollection<IFileSystemComponent> Components { get; }
}