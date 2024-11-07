using Visitor.FileSystemStructure;

namespace Iterator.Extensions;

public static class FileSystemComponentExtensions
{
    public static IEnumerable<IFileSystemComponent> EnumerateBreadth(this IFileSystemComponent component) { }

    public static IEnumerable<IFileSystemComponent> EnumerateDepth(this IFileSystemComponent component) { }
}