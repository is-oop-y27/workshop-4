using System.Drawing;

namespace ResponsibilityChain.TextModifiers;

public class ColorTextModifier(Color color) : ITextModifier
{
    public string Modify(string text)
        => Crayon.Output.Rgb(color.R, color.G, color.B).Text(text);
}