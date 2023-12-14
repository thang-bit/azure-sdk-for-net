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
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary>
    /// A Class representing a ServiceBusDisasterRecovery along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ServiceBusDisasterRecoveryResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetServiceBusDisasterRecoveryResource method.
    /// Otherwise you can get one from its parent resource <see cref="ServiceBusNamespaceResource"/> using the GetServiceBusDisasterRecovery method.
    /// </summary>
    public partial class ServiceBusDisasterRecoveryResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServiceBusDisasterRecoveryResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="namespaceName"> The namespaceName. </param>
        /// <param name="alias"> The alias. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string @alias)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{@alias}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _serviceBusDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics;
        private readonly DisasterRecoveryConfigsRestOperations _serviceBusDisasterRecoveryDisasterRecoveryConfigsRestClient;
        private readonly ServiceBusDisasterRecoveryData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ServiceBus/namespaces/disasterRecoveryConfigs";

        /// <summary> Initializes a new instance of the <see cref="ServiceBusDisasterRecoveryResource"/> class for mocking. </summary>
        protected ServiceBusDisasterRecoveryResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceBusDisasterRecoveryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ServiceBusDisasterRecoveryResource(ArmClient client, ServiceBusDisasterRecoveryData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceBusDisasterRecoveryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServiceBusDisasterRecoveryResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceBusDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string serviceBusDisasterRecoveryDisasterRecoveryConfigsApiVersion);
            _serviceBusDisasterRecoveryDisasterRecoveryConfigsRestClient = new DisasterRecoveryConfigsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceBusDisasterRecoveryDisasterRecoveryConfigsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ServiceBusDisasterRecoveryData Data
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

        /// <summary> Gets a collection of ServiceBusDisasterRecoveryAuthorizationRuleResources in the ServiceBusDisasterRecovery. </summary>
        /// <returns> An object representing collection of ServiceBusDisasterRecoveryAuthorizationRuleResources and their operations over a ServiceBusDisasterRecoveryAuthorizationRuleResource. </returns>
        public virtual ServiceBusDisasterRecoveryAuthorizationRuleCollection GetServiceBusDisasterRecoveryAuthorizationRules()
        {
            return GetCachedClient(client => new ServiceBusDisasterRecoveryAuthorizationRuleCollection(client, Id));
        }

        /// <summary>
        /// Gets an authorization rule for a namespace by rule name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryAuthorizationRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ServiceBusDisasterRecoveryAuthorizationRuleResource>> GetServiceBusDisasterRecoveryAuthorizationRuleAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            return await GetServiceBusDisasterRecoveryAuthorizationRules().GetAsync(authorizationRuleName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an authorization rule for a namespace by rule name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/authorizationRules/{authorizationRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryAuthorizationRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ServiceBusDisasterRecoveryAuthorizationRuleResource> GetServiceBusDisasterRecoveryAuthorizationRule(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            return GetServiceBusDisasterRecoveryAuthorizationRules().Get(authorizationRuleName, cancellationToken);
        }

        /// <summary>
        /// Retrieves Alias(Disaster Recovery configuration) for primary or secondary namespace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServiceBusDisasterRecoveryResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("ServiceBusDisasterRecoveryResource.Get");
            scope.Start();
            try
            {
                var response = await _serviceBusDisasterRecoveryDisasterRecoveryConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceBusDisasterRecoveryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves Alias(Disaster Recovery configuration) for primary or secondary namespace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServiceBusDisasterRecoveryResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("ServiceBusDisasterRecoveryResource.Get");
            scope.Start();
            try
            {
                var response = _serviceBusDisasterRecoveryDisasterRecoveryConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceBusDisasterRecoveryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an Alias(Disaster Recovery configuration)
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("ServiceBusDisasterRecoveryResource.Delete");
            scope.Start();
            try
            {
                var response = await _serviceBusDisasterRecoveryDisasterRecoveryConfigsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceBusArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an Alias(Disaster Recovery configuration)
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("ServiceBusDisasterRecoveryResource.Delete");
            scope.Start();
            try
            {
                var response = _serviceBusDisasterRecoveryDisasterRecoveryConfigsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new ServiceBusArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a new Alias(Disaster Recovery configuration)
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters required to create an Alias(Disaster Recovery configuration). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceBusDisasterRecoveryResource>> UpdateAsync(WaitUntil waitUntil, ServiceBusDisasterRecoveryData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceBusDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("ServiceBusDisasterRecoveryResource.Update");
            scope.Start();
            try
            {
                var response = await _serviceBusDisasterRecoveryDisasterRecoveryConfigsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceBusArmOperation<ServiceBusDisasterRecoveryResource>(Response.FromValue(new ServiceBusDisasterRecoveryResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a new Alias(Disaster Recovery configuration)
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters required to create an Alias(Disaster Recovery configuration). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceBusDisasterRecoveryResource> Update(WaitUntil waitUntil, ServiceBusDisasterRecoveryData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceBusDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("ServiceBusDisasterRecoveryResource.Update");
            scope.Start();
            try
            {
                var response = _serviceBusDisasterRecoveryDisasterRecoveryConfigsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new ServiceBusArmOperation<ServiceBusDisasterRecoveryResource>(Response.FromValue(new ServiceBusDisasterRecoveryResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation disables the Disaster Recovery and stops replicating changes from primary to secondary namespaces
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/breakPairing</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_BreakPairing</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> BreakPairingAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("ServiceBusDisasterRecoveryResource.BreakPairing");
            scope.Start();
            try
            {
                var response = await _serviceBusDisasterRecoveryDisasterRecoveryConfigsRestClient.BreakPairingAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation disables the Disaster Recovery and stops replicating changes from primary to secondary namespaces
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/breakPairing</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_BreakPairing</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response BreakPairing(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("ServiceBusDisasterRecoveryResource.BreakPairing");
            scope.Start();
            try
            {
                var response = _serviceBusDisasterRecoveryDisasterRecoveryConfigsRestClient.BreakPairing(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Invokes GEO DR failover and reconfigure the alias to point to the secondary namespace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/failover</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_FailOver</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="failoverProperties"> Parameters required to create an Alias(Disaster Recovery configuration). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> FailOverAsync(FailoverProperties failoverProperties = null, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("ServiceBusDisasterRecoveryResource.FailOver");
            scope.Start();
            try
            {
                var response = await _serviceBusDisasterRecoveryDisasterRecoveryConfigsRestClient.FailOverAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, failoverProperties, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Invokes GEO DR failover and reconfigure the alias to point to the secondary namespace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/{alias}/failover</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DisasterRecoveryConfigs_FailOver</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="failoverProperties"> Parameters required to create an Alias(Disaster Recovery configuration). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response FailOver(FailoverProperties failoverProperties = null, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusDisasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("ServiceBusDisasterRecoveryResource.FailOver");
            scope.Start();
            try
            {
                var response = _serviceBusDisasterRecoveryDisasterRecoveryConfigsRestClient.FailOver(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, failoverProperties, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
