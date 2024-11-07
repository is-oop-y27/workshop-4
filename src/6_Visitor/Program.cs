using Visitor.FileSystemStructure;

var factory = new FileSystemComponentFactory();
IFileSystemComponent component = factory.Create("sample_folder");