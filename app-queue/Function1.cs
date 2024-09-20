using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace app_queue
{
    public class Function1
    {
        [FunctionName("Function1")]
        public void Run([RabbitMQTrigger("EntryQueue", ConnectionStringSetting = "RabbitMQConnection")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
