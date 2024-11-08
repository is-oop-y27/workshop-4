namespace ResponsibilityChain.TextModifiers;

public class AggregateModifier(ITextModifier? left, ITextModifier right) : ITextModifier
{
    public string Modify(string text)
    {
        if (left is null)
            return right.Modify(text);

        text = left.Modify(text);
        return right.Modify(text);
    }
}