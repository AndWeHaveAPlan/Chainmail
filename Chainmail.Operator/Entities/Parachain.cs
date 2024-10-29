using k8s.Models;
using KubeOps.Abstractions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chainmail.Operator.Entities
{
    [KubernetesEntity(Group = "parity.org", ApiVersion = "v1", Kind = "Parachain")]
    public class V1Parachain: CustomKubernetesEntity<V1Parachain.EntitySpec, V1Parachain.EntityStatus>
    {
        public override string ToString()
            => $"Test Entity ({Metadata.Name}): {Spec.Name} ({Spec.Something})";

        public class EntitySpec
        {
            public string Name { get; set; } = string.Empty;

            public string Something { get; set; } = string.Empty;
        }

        public class EntityStatus
        {
            public string Status { get; set; } = string.Empty;
        }
    }
}
