using Dapr.Workflow;

var builder = WebApplication.CreateBuilder(args);


var apiToken = Environment.GetEnvironmentVariable("DAPR_API_TOKEN");
var grpcEndpoint = Environment.GetEnvironmentVariable("DAPR_GRPC_ENDPOINT");
var httpEndpoint = Environment.GetEnvironmentVariable("DAPR_HTTP_ENDPOINT");
var appId = Environment.GetEnvironmentVariable("DAPR_APP_ID");


builder.Services.AddDaprClient(options => {
    options.UseDaprApiToken(apiToken);
    options.UseGrpcEndpoint(grpcEndpoint);
    options.UseHttpEndpoint(httpEndpoint);
});

builder.Services.AddDaprWorkflowClient();
builder.Services.AddDaprWorkflow(options =>
{
    options.RegisterWorkflow<TestWorkflow>();
    options.RegisterActivity<Activity1>();
    options.RegisterActivity<Activity2>();
    options.RegisterActivity<Activity3>();
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
