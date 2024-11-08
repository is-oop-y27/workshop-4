using State.Models;
using State.Results;

namespace State.StateHandlers;

public interface ISubmissionStateHandler
{
    SubmissionState State { get; }

    SubmissionStateMoveResult MoveToActive();

    SubmissionStateMoveResult MoveToCompleted();

    SubmissionStateMoveResult MoveToBanned();
}