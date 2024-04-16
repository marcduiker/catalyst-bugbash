# catalyst-bugbash

## Daigrid project

`diagrid login --api https://api.stg.diagrid.io`

`diagrid project create marc-wf-prj --deploy-managed-pubsub --deploy-managed-kv --enable-managed-workflow --wait`

`diagrid project use marc-wf-prj`

`diagrid appid create wfservice`

`diagrid appid get wfservice --project marc-wf-prj`

`cd src`

`dotnet new web -n wfservice`

`cd wfservice`

`dotnet add package Dapr.Workflow`

Add env variable:
`DAPR_API_TOKEN=diagrid:`