using Iterator.Iterators;
using Visitor.FileSystemStructure;

namespace Iterator.Extensions;

public static class FileSystemComponentExtensions
{
    public static IEnumerator<IFileSystemComponent> EnumerateBreadth(this IFileSystemComponent component)
        => new FileSystemBreadthIterator(component);

    public static IEnumerator<IFileSystemComponent> EnumerateDepth(this IFileSystemComponent component)
    {
        return new FileSystemDepthIterator(component);
    }
}