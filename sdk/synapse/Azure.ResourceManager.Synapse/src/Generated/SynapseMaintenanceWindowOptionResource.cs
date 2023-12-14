// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A Class representing a SynapseMaintenanceWindowOption along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SynapseMaintenanceWindowOptionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSynapseMaintenanceWindowOptionResource method.
    /// Otherwise you can get one from its parent resource <see cref="SynapseSqlPoolResource"/> using the GetSynapseMaintenanceWindowOption method.
    /// </summary>
    public partial class SynapseMaintenanceWindowOptionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SynapseMaintenanceWindowOptionResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="workspaceName"> The workspaceName. </param>
        /// <param name="sqlPoolName"> The sqlPoolName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/maintenanceWindowOptions/current";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _synapseMaintenanceWindowOptionSqlPoolMaintenanceWindowOptionsClientDiagnostics;
        private readonly SqlPoolMaintenanceWindowOptionsRestOperations _synapseMaintenanceWindowOptionSqlPoolMaintenanceWindowOptionsRestClient;
        private readonly SynapseMaintenanceWindowOptionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Synapse/workspaces/sqlPools/maintenanceWindowOptions";

        /// <summary> Initializes a new instance of the <see cref="SynapseMaintenanceWindowOptionResource"/> class for mocking. </summary>
        protected SynapseMaintenanceWindowOptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseMaintenanceWindowOptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SynapseMaintenanceWindowOptionResource(ArmClient client, SynapseMaintenanceWindowOptionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseMaintenanceWindowOptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SynapseMaintenanceWindowOptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseMaintenanceWindowOptionSqlPoolMaintenanceWindowOptionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string synapseMaintenanceWindowOptionSqlPoolMaintenanceWindowOptionsApiVersion);
            _synapseMaintenanceWindowOptionSqlPoolMaintenanceWindowOptionsRestClient = new SqlPoolMaintenanceWindowOptionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseMaintenanceWindowOptionSqlPoolMaintenanceWindowOptionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SynapseMaintenanceWindowOptionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get list of SQL pool's available maintenance windows.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/maintenanceWindowOptions/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolMaintenanceWindowOptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maintenanceWindowOptionsName"> Maintenance window options name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="maintenanceWindowOptionsName"/> is null. </exception>
        public virtual async Task<Response<SynapseMaintenanceWindowOptionResource>> GetAsync(string maintenanceWindowOptionsName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(maintenanceWindowOptionsName, nameof(maintenanceWindowOptionsName));

            using var scope = _synapseMaintenanceWindowOptionSqlPoolMaintenanceWindowOptionsClientDiagnostics.CreateScope("SynapseMaintenanceWindowOptionResource.Get");
            scope.Start();
            try
            {
                var response = await _synapseMaintenanceWindowOptionSqlPoolMaintenanceWindowOptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, maintenanceWindowOptionsName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseMaintenanceWindowOptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get list of SQL pool's available maintenance windows.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/maintenanceWindowOptions/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolMaintenanceWindowOptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maintenanceWindowOptionsName"> Maintenance window options name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="maintenanceWindowOptionsName"/> is null. </exception>
        public virtual Response<SynapseMaintenanceWindowOptionResource> Get(string maintenanceWindowOptionsName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(maintenanceWindowOptionsName, nameof(maintenanceWindowOptionsName));

            using var scope = _synapseMaintenanceWindowOptionSqlPoolMaintenanceWindowOptionsClientDiagnostics.CreateScope("SynapseMaintenanceWindowOptionResource.Get");
            scope.Start();
            try
            {
                var response = _synapseMaintenanceWindowOptionSqlPoolMaintenanceWindowOptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, maintenanceWindowOptionsName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseMaintenanceWindowOptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
