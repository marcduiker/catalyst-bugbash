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

        var result3 =await context.CallActivityAsync<string>(
            nameof(Activity3),
            result2);

        // var tasks = new List<Task<string>>();

        // tasks.Add(context.CallActivityAsync<string>(
        //     nameof(Activity1),
        //     input));
        // tasks.Add(context.CallActivityAsync<string>(
        //     nameof(Activity2),
        //     input));
        // tasks.Add(context.CallActivityAsync<string>(
        //     nameof(Activity3),
        //     input));

        // var endResult = await Task.WhenAll(tasks);

        return result3;
    }
}