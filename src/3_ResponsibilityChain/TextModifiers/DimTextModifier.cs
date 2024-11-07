namespace ResponsibilityChain.TextModifiers;

public class DimTextModifier : ITextModifier
{
    public string Modify(string text) 
        => Crayon.Output.Dim(text);
}