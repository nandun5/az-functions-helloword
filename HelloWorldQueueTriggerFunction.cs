using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Nandun.Functions
{
    public static class HelloWorldQueueTriggerFunction
    {
        [FunctionName("HelloWorldQueueTriggerFunction")]
        public static void Run([QueueTrigger("helloworldqueueitem", Connection = "funkythefunctioadata01_STORAGE")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
