using Chainmail.Operator.Entities;
using KubeOps.Abstractions.Controller;
using KubeOps.Abstractions.Rbac;
using Microsoft.Extensions.Logging;

namespace Chainmail.Operator.Controllers;

[EntityRbac(typeof(V1Parachain), Verbs = RbacVerb.All)]
public class V1ParachainController(ILogger<V1ParachainController> logger)
    : IEntityController<V1Parachain>
{
    public Task ReconcileAsync(V1Parachain entity, CancellationToken cancellationToken)
    {
        logger.LogInformation("Reconciling entity {Entity}.", entity);
        return Task.CompletedTask;
    }

    public Task DeletedAsync(V1Parachain entity, CancellationToken cancellationToken)
    {
        logger.LogInformation("Deleting entity {Entity}.", entity);
        return Task.CompletedTask;
    }
}