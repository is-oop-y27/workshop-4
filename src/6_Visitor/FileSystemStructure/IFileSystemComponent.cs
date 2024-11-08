using Visitor.Visitors;

namespace Visitor.FileSystemStructure;

public interface IFileSystemComponent
{
    string Name { get; }

    void Accept(IFileSystemComponentVisitor visitor);
}