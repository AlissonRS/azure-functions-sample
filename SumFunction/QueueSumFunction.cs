using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SumFunction.Models;
using SumFunction.Services;

namespace SumFunction
{
    public static class QueueSumFunction
    {
        [FunctionName("QueueSumFunction")]
        public static void Run([QueueTrigger("sum-items", Connection = "AzureWebJobsStorage")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");

            var item = JsonConvert.DeserializeObject<SumItem>(myQueueItem);
            var service = new SumService();
            var output = service.Sum(item);

            log.LogInformation("The sum is {0}", output);
        }
    }
}
