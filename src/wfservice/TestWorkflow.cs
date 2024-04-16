using Dapr.Workflow;

public class TestWorkflow : Workflow<string, string>
{
    public override async Task<string> RunAsync(WorkflowContext context, string input)
    {
        var result1 = await context.CallActivityAsync<string>(
            nameof(Activity1),
            input);

        var result2 =await context.CallActivityAsync<string>(
            nameof(Activity2),
            result1);

        return result2;
    }
}