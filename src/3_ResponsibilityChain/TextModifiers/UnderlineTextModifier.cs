namespace ResponsibilityChain.TextModifiers;

public class UnderlineTextModifier : ITextModifier
{
    public string Modify(string text)
        => Crayon.Output.Underline(text);
}