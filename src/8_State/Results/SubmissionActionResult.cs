using State.Models;

namespace State.Results;

public abstract record SubmissionActionResult
{
    private SubmissionActionResult() { }

    public sealed record Success : SubmissionActionResult;

    public sealed record InvalidState(SubmissionState CurrentState) : SubmissionActionResult;
}