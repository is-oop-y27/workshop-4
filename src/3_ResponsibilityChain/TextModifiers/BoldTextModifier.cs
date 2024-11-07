namespace ResponsibilityChain.TextModifiers;

public class BoldTextModifier : ITextModifier
{
    public string Modify(string text)
        => Crayon.Output.Bold(text);
}