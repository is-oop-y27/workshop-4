namespace Visitor.FileSystemStructure;

public class FileSystemComponentFactory
{
    public IFileSystemComponent Create(string path)
    {
        if (Directory.Exists(path))
        {
            string? name = Path.GetFileName(path);

            IEnumerable<string> names = Directory
                .EnumerateFileSystemEntries(path)
                .Select(Path.GetFileName)
                .Where(x => x is not null)
                .Cast<string>();

            IFileSystemComponent[] components = names
                .Select(entry => Path.Combine(path, entry))
                .Select(Create)
                .ToArray();

            return new DirectoryFileSystemComponent(name ?? string.Empty, components);
        }

        if (File.Exists(path))
        {
            string name = Path.GetFileName(path);
            return new FileFileSystemComponent(name);
        }

        throw new InvalidOperationException($"File system component at {path} is not found");
    }
}