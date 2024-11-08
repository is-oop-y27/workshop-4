using Visitor.FileSystemStructure;

namespace Visitor.Visitors;

public interface IFileSystemComponentVisitor
{
    void Visit(FileFileSystemComponent component);

    void Visit(DirectoryFileSystemComponent component);
}