using Dapr.Client;
using Dapr.Workflow;

public class Activity3 : WorkflowActivity<string, string>
{
    private readonly DaprClient _daprClient;

    public Activity3(DaprClient daprClient)
    {
        _daprClient = daprClient;
    }

    public override async Task<string> RunAsync(WorkflowActivityContext context, string input)
    {
        var key = Guid.NewGuid().ToString();
        await _daprClient.SaveStateAsync("kvstore", Guid.NewGuid().ToString(),input);

        return key;
    }
}