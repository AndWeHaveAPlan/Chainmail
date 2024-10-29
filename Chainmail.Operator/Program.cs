using Chainmail.Operator.Controllers;
using Chainmail.Operator.Entities;
using KubeOps.Operator;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Chainmail.Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = Host.CreateApplicationBuilder(args);

            builder.Logging.SetMinimumLevel(LogLevel.Trace);

            builder.Services
                .AddKubernetesOperator()
                .AddController<V1ParachainController, V1Parachain>();

            using var host = builder.Build();
            host.Run();
        }
    }
}
