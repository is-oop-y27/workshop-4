using ResponsibilityChain.TextModifiers;

namespace ResponsibilityChain.ParameterHandlers;

public interface IParameterHandler
{
    IParameterHandler AddNext(IParameterHandler handler);

    ITextModifier? Handle(IEnumerator<string> request);
}