using Visitor.FileSystemStructure;
using Visitor.Visitors;

var factory = new FileSystemComponentFactory();
IFileSystemComponent component = factory.Create("sample_folder");

var visitor = new ConsoleVisitor();

component.Accept(visitor);