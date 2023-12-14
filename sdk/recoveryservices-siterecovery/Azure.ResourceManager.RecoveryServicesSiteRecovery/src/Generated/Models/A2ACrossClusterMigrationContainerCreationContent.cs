// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> A2ACrossClusterMigration cloud creation input. </summary>
    public partial class A2ACrossClusterMigrationContainerCreationContent : ReplicationProviderSpecificContainerCreationContent
    {
        /// <summary> Initializes a new instance of <see cref="A2ACrossClusterMigrationContainerCreationContent"/>. </summary>
        public A2ACrossClusterMigrationContainerCreationContent()
        {
            InstanceType = "A2ACrossClusterMigration";
        }

        /// <summary> Initializes a new instance of <see cref="A2ACrossClusterMigrationContainerCreationContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        internal A2ACrossClusterMigrationContainerCreationContent(string instanceType) : base(instanceType)
        {
            InstanceType = instanceType ?? "A2ACrossClusterMigration";
        }
    }
}
