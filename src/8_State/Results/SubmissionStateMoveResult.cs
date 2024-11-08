using State.StateHandlers;

namespace State.Results;

public abstract record SubmissionStateMoveResult
{
    private SubmissionStateMoveResult() { }

    public sealed record Success(ISubmissionStateHandler Next) : SubmissionStateMoveResult;

    public sealed record InvalidMove : SubmissionStateMoveResult;
}