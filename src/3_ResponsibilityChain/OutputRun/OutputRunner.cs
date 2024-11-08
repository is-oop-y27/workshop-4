using ResponsibilityChain.ParameterHandlers;
using ResponsibilityChain.TextModifiers;

namespace ResponsibilityChain.OutputRun;

public class OutputRunner : IOutputRunner
{
    private readonly IParameterHandler _handler;

    public OutputRunner(IParameterHandler handler)
    {
        _handler = handler;
    }

    public void Run(IEnumerable<string> args)
    {
        using IEnumerator<string> request = args.GetEnumerator();
        ITextModifier? modifier = null;

        while (request.MoveNext())
        {
            ITextModifier? nextModifier = _handler.Handle(request);

            if (nextModifier is not null)
            {
                modifier = new AggregateModifier(modifier, nextModifier);
            }
        }

        var text = "Hello world!";
        text = modifier?.Modify(text) ?? text;

        Console.WriteLine(text);
    }
}