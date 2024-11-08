using Iterator.Extensions;
using Visitor.FileSystemStructure;

var factory = new FileSystemComponentFactory();
IFileSystemComponent component = factory.Create("sample_folder");

using IEnumerator<IFileSystemComponent> breadthIterator = component.EnumerateBreadth();

Console.WriteLine("Breadth");

while (breadthIterator.MoveNext())
{
    Console.WriteLine(breadthIterator.Current.Name);
}

Console.WriteLine();
Console.WriteLine("Depth");

using IEnumerator<IFileSystemComponent> depthIterator = component.EnumerateDepth();

while (depthIterator.MoveNext())
{
    Console.WriteLine(depthIterator.Current.Name);
}