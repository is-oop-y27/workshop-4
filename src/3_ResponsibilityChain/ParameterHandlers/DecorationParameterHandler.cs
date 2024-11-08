using ResponsibilityChain.TextModifiers;

namespace ResponsibilityChain.ParameterHandlers;

public class DecorationParameterHandler : ParameterHandlerBase
{
    public override ITextModifier? Handle(IEnumerator<string> request)
    {
        if (request.Current is not "--decoration")
            return Next?.Handle(request);

        if (request.MoveNext() is false)
            return null;

        ITextModifier? modifier = request.Current switch
        {
            "bold" => new BoldTextModifier(),
            "underline" => new UnderlineTextModifier(),
            "dim" => new DimTextModifier(),
            _ => null,
        };

        return modifier ?? Next?.Handle(request);
    }
}