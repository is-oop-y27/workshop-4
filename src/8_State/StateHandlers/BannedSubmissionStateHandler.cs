using State.Models;
using State.Results;

namespace State.StateHandlers;

public class BannedSubmissionStateHandler : ISubmissionStateHandler
{
    public SubmissionState State => SubmissionState.Banned;

    public SubmissionStateMoveResult MoveToActive()
        => new SubmissionStateMoveResult.InvalidMove();

    public SubmissionStateMoveResult MoveToCompleted()
        => new SubmissionStateMoveResult.InvalidMove();

    public SubmissionStateMoveResult MoveToBanned()
        => new SubmissionStateMoveResult.Success(this);
}