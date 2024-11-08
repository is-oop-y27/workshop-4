using State.Models;
using State.Results;

namespace State.StateHandlers;

public class ActiveSubmissionStateHandler : ISubmissionStateHandler
{
    public SubmissionState State => SubmissionState.Active;

    public SubmissionStateMoveResult MoveToActive()
        => new SubmissionStateMoveResult.Success(this);

    public SubmissionStateMoveResult MoveToCompleted()
        => new SubmissionStateMoveResult.Success(new CompletedSubmissionStateHandler());

    public SubmissionStateMoveResult MoveToBanned()
        => new SubmissionStateMoveResult.Success(new BannedSubmissionStateHandler());
}