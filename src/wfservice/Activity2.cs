using Dapr.Workflow;

public class Activity2 : WorkflowActivity<string, string>
{
    public override Task<string> RunAsync(WorkflowActivityContext context, string input)
    {
        return Task.FromResult($"{input}-2");
    }
}