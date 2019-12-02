# azure-functions-sample
Sample code that can be triggered by http request or message queue that sums two properties.

You have to update `local.settings.json` with your own **Azure Storage Connection String**.

When you run the project (F5), the console will give you a local endpoint for triggering the code with an http request (e.g from postman).

You can import this cURL command into postman. The same json body can be used when adding a message in the queue used by the QueueTrigger:

```
curl -X POST \
  http://localhost:7071/api/HttpSumFunction \
  -H 'Accept: */*' \
  -H 'Accept-Encoding: gzip, deflate' \
  -H 'Cache-Control: no-cache' \
  -H 'Connection: keep-alive' \
  -H 'Content-Length: 28' \
  -H 'Content-Type: application/json' \
  -H 'Host: localhost:7071' \
  -H 'Postman-Token: 3d19926f-7e3f-484a-aa9c-9084cb9dafb6,6e87ab11-daa3-4d45-9965-17c7d144fc6d' \
  -H 'User-Agent: PostmanRuntime/7.20.1' \
  -H 'cache-control: no-cache' \
  -d '{
    "A": 20,
    "B": 30
}'
```