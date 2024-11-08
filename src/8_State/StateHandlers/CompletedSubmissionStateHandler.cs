using State.Models;
using State.Results;

namespace State.StateHandlers;

public class CompletedSubmissionStateHandler : ISubmissionStateHandler
{
    public SubmissionState State => SubmissionState.Completed;

    public SubmissionStateMoveResult MoveToActive()
        => new SubmissionStateMoveResult.InvalidMove();

    public SubmissionStateMoveResult MoveToCompleted()
        => new SubmissionStateMoveResult.Success(this);

    public SubmissionStateMoveResult MoveToBanned()
        => new SubmissionStateMoveResult.Success(new BannedSubmissionStateHandler());
}