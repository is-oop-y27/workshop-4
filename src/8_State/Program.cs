// See https://aka.ms/new-console-template for more information

using State.Models;
using State.Results;
using State.StateHandlers;

var submission = new Submission(new ActiveSubmissionStateHandler());

submission.Complete();
submission.Ban();

SubmissionActionResult result = submission.Complete();
Console.WriteLine(result);