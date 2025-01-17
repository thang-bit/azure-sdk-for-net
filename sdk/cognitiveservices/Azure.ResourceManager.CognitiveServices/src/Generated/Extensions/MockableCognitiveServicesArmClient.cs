// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.CognitiveServices;

namespace Azure.ResourceManager.CognitiveServices.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableCognitiveServicesArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableCognitiveServicesArmClient"/> class for mocking. </summary>
        protected MockableCognitiveServicesArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableCognitiveServicesArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableCognitiveServicesArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableCognitiveServicesArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="CognitiveServicesAccountResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CognitiveServicesAccountResource.CreateResourceIdentifier" /> to create a <see cref="CognitiveServicesAccountResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CognitiveServicesAccountResource"/> object. </returns>
        public virtual CognitiveServicesAccountResource GetCognitiveServicesAccountResource(ResourceIdentifier id)
        {
            CognitiveServicesAccountResource.ValidateResourceId(id);
            return new CognitiveServicesAccountResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CognitiveServicesDeletedAccountResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CognitiveServicesDeletedAccountResource.CreateResourceIdentifier" /> to create a <see cref="CognitiveServicesDeletedAccountResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CognitiveServicesDeletedAccountResource"/> object. </returns>
        public virtual CognitiveServicesDeletedAccountResource GetCognitiveServicesDeletedAccountResource(ResourceIdentifier id)
        {
            CognitiveServicesDeletedAccountResource.ValidateResourceId(id);
            return new CognitiveServicesDeletedAccountResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CognitiveServicesPrivateEndpointConnectionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CognitiveServicesPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="CognitiveServicesPrivateEndpointConnectionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CognitiveServicesPrivateEndpointConnectionResource"/> object. </returns>
        public virtual CognitiveServicesPrivateEndpointConnectionResource GetCognitiveServicesPrivateEndpointConnectionResource(ResourceIdentifier id)
        {
            CognitiveServicesPrivateEndpointConnectionResource.ValidateResourceId(id);
            return new CognitiveServicesPrivateEndpointConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CognitiveServicesAccountDeploymentResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CognitiveServicesAccountDeploymentResource.CreateResourceIdentifier" /> to create a <see cref="CognitiveServicesAccountDeploymentResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CognitiveServicesAccountDeploymentResource"/> object. </returns>
        public virtual CognitiveServicesAccountDeploymentResource GetCognitiveServicesAccountDeploymentResource(ResourceIdentifier id)
        {
            CognitiveServicesAccountDeploymentResource.ValidateResourceId(id);
            return new CognitiveServicesAccountDeploymentResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CommitmentPlanResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CommitmentPlanResource.CreateResourceIdentifier" /> to create a <see cref="CommitmentPlanResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CommitmentPlanResource"/> object. </returns>
        public virtual CommitmentPlanResource GetCommitmentPlanResource(ResourceIdentifier id)
        {
            CommitmentPlanResource.ValidateResourceId(id);
            return new CommitmentPlanResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CognitiveServicesCommitmentPlanResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CognitiveServicesCommitmentPlanResource.CreateResourceIdentifier" /> to create a <see cref="CognitiveServicesCommitmentPlanResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CognitiveServicesCommitmentPlanResource"/> object. </returns>
        public virtual CognitiveServicesCommitmentPlanResource GetCognitiveServicesCommitmentPlanResource(ResourceIdentifier id)
        {
            CognitiveServicesCommitmentPlanResource.ValidateResourceId(id);
            return new CognitiveServicesCommitmentPlanResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CommitmentPlanAccountAssociationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CommitmentPlanAccountAssociationResource.CreateResourceIdentifier" /> to create a <see cref="CommitmentPlanAccountAssociationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CommitmentPlanAccountAssociationResource"/> object. </returns>
        public virtual CommitmentPlanAccountAssociationResource GetCommitmentPlanAccountAssociationResource(ResourceIdentifier id)
        {
            CommitmentPlanAccountAssociationResource.ValidateResourceId(id);
            return new CommitmentPlanAccountAssociationResource(Client, id);
        }
    }
}
