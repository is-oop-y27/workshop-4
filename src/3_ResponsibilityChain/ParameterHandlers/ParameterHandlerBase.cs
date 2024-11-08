using ResponsibilityChain.TextModifiers;

namespace ResponsibilityChain.ParameterHandlers;

public abstract class ParameterHandlerBase : IParameterHandler
{
    protected IParameterHandler? Next { get; private set; }

    public IParameterHandler AddNext(IParameterHandler handler)
    {
        if (Next is null)
        {
            Next = handler;
        }
        else
        {
            Next.AddNext(handler);
        }

        return this;
    }

    public abstract ITextModifier? Handle(IEnumerator<string> request);
}