using ResponsibilityChain.OutputRun;
using ResponsibilityChain.ParameterHandlers;

IParameterHandler handler = new ColorParameterHandler()
    .AddNext(new DecorationParameterHandler());

IOutputRunner runner = new OutputRunner(handler);
runner.Run(args);