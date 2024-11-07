using State.Results;

namespace State.Models;

public class Submission
{
    public Submission(SubmissionState state)
    {
        State = state;
    }

    public SubmissionState State { get; }

    public SubmissionActionResult Activate() { }

    public SubmissionActionResult Complete() { }

    public SubmissionActionResult Ban() { }
}