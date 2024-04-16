using Dapr.Workflow;

public class Activity2 : WorkflowActivity<string, string>
{
    public override async Task<string> RunAsync(WorkflowActivityContext context, string input)
    {
        return $"{input}-2";
    }
}