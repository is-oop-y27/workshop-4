using System.Drawing;
using ResponsibilityChain.TextModifiers;

namespace ResponsibilityChain.ParameterHandlers;

public class ColorParameterHandler : ParameterHandlerBase
{
    public override ITextModifier? Handle(IEnumerator<string> request)
    {
        if (request.Current is not "--color")
            return Next?.Handle(request);

        if (request.MoveNext() is false)
            return null;

        Color? color = request.Current switch
        {
            "red" => Color.Red,
            "green" => Color.Green,
            "blue" => Color.Blue,
            "pink" => Color.Pink,
            "cyan" => Color.Cyan,
            "brown" => Color.Brown,
            _ => null,
        };

        if (color is null)
            return Next?.Handle(request);

        return new ColorTextModifier(color.Value);
    }
}