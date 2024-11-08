using State.Results;
using State.StateHandlers;

namespace State.Models;

public class Submission
{
    private ISubmissionStateHandler _stateHandler;

    public Submission(ISubmissionStateHandler stateHandler)
    {
        _stateHandler = stateHandler;
    }

    public SubmissionState State => _stateHandler.State;

    public SubmissionActionResult Activate()
    {
        SubmissionStateMoveResult result = _stateHandler.MoveToActive();

        if (result is not SubmissionStateMoveResult.Success success)
            return new SubmissionActionResult.InvalidState(_stateHandler.State);

        _stateHandler = success.Next;
        return new SubmissionActionResult.Success();
    }

    public SubmissionActionResult Complete()
    {
        SubmissionStateMoveResult result = _stateHandler.MoveToCompleted();

        if (result is not SubmissionStateMoveResult.Success success)
            return new SubmissionActionResult.InvalidState(_stateHandler.State);

        _stateHandler = success.Next;
        return new SubmissionActionResult.Success();
    }

    public SubmissionActionResult Ban()
    {
        SubmissionStateMoveResult result = _stateHandler.MoveToBanned();

        if (result is not SubmissionStateMoveResult.Success success)
            return new SubmissionActionResult.InvalidState(_stateHandler.State);

        _stateHandler = success.Next;
        return new SubmissionActionResult.Success();
    }
}