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
using Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    /// <summary>
    /// A Class representing a LocalRulestackRule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="LocalRulestackRuleResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetLocalRulestackRuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="LocalRulestackResource"/> using the GetLocalRulestackRule method.
    /// </summary>
    public partial class LocalRulestackRuleResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="LocalRulestackRuleResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="localRulestackName"> The localRulestackName. </param>
        /// <param name="priority"> The priority. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string localRulestackName, string priority)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/localRules/{priority}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _localRulestackRuleLocalRulesClientDiagnostics;
        private readonly LocalRulesRestOperations _localRulestackRuleLocalRulesRestClient;
        private readonly LocalRulestackRuleData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "PaloAltoNetworks.Cloudngfw/localRulestacks/localRules";

        /// <summary> Initializes a new instance of the <see cref="LocalRulestackRuleResource"/> class for mocking. </summary>
        protected LocalRulestackRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LocalRulestackRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal LocalRulestackRuleResource(ArmClient client, LocalRulestackRuleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="LocalRulestackRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal LocalRulestackRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _localRulestackRuleLocalRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PaloAltoNetworks.Ngfw", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string localRulestackRuleLocalRulesApiVersion);
            _localRulestackRuleLocalRulesRestClient = new LocalRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, localRulestackRuleLocalRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual LocalRulestackRuleData Data
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
        /// Get a LocalRulesResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/localRules/{priority}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LocalRulestackRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _localRulestackRuleLocalRulesClientDiagnostics.CreateScope("LocalRulestackRuleResource.Get");
            scope.Start();
            try
            {
                var response = await _localRulestackRuleLocalRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LocalRulestackRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a LocalRulesResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/localRules/{priority}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LocalRulestackRuleResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _localRulestackRuleLocalRulesClientDiagnostics.CreateScope("LocalRulestackRuleResource.Get");
            scope.Start();
            try
            {
                var response = _localRulestackRuleLocalRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LocalRulestackRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a LocalRulesResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/localRules/{priority}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalRules_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _localRulestackRuleLocalRulesClientDiagnostics.CreateScope("LocalRulestackRuleResource.Delete");
            scope.Start();
            try
            {
                var response = await _localRulestackRuleLocalRulesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NgfwArmOperation(_localRulestackRuleLocalRulesClientDiagnostics, Pipeline, _localRulestackRuleLocalRulesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Delete a LocalRulesResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/localRules/{priority}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalRules_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _localRulestackRuleLocalRulesClientDiagnostics.CreateScope("LocalRulestackRuleResource.Delete");
            scope.Start();
            try
            {
                var response = _localRulestackRuleLocalRulesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new NgfwArmOperation(_localRulestackRuleLocalRulesClientDiagnostics, Pipeline, _localRulestackRuleLocalRulesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a LocalRulesResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/localRules/{priority}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<LocalRulestackRuleResource>> UpdateAsync(WaitUntil waitUntil, LocalRulestackRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _localRulestackRuleLocalRulesClientDiagnostics.CreateScope("LocalRulestackRuleResource.Update");
            scope.Start();
            try
            {
                var response = await _localRulestackRuleLocalRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new NgfwArmOperation<LocalRulestackRuleResource>(new LocalRulestackRuleOperationSource(Client), _localRulestackRuleLocalRulesClientDiagnostics, Pipeline, _localRulestackRuleLocalRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a LocalRulesResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/localRules/{priority}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<LocalRulestackRuleResource> Update(WaitUntil waitUntil, LocalRulestackRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _localRulestackRuleLocalRulesClientDiagnostics.CreateScope("LocalRulestackRuleResource.Update");
            scope.Start();
            try
            {
                var response = _localRulestackRuleLocalRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new NgfwArmOperation<LocalRulestackRuleResource>(new LocalRulestackRuleOperationSource(Client), _localRulestackRuleLocalRulesClientDiagnostics, Pipeline, _localRulestackRuleLocalRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get counters
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/localRules/{priority}/getCounters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalRules_getCounters</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FirewallRuleCounter>> GetCountersAsync(string firewallName = null, CancellationToken cancellationToken = default)
        {
            using var scope = _localRulestackRuleLocalRulesClientDiagnostics.CreateScope("LocalRulestackRuleResource.GetCounters");
            scope.Start();
            try
            {
                var response = await _localRulestackRuleLocalRulesRestClient.GetCountersAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, firewallName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get counters
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/localRules/{priority}/getCounters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalRules_getCounters</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FirewallRuleCounter> GetCounters(string firewallName = null, CancellationToken cancellationToken = default)
        {
            using var scope = _localRulestackRuleLocalRulesClientDiagnostics.CreateScope("LocalRulestackRuleResource.GetCounters");
            scope.Start();
            try
            {
                var response = _localRulestackRuleLocalRulesRestClient.GetCounters(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, firewallName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Refresh counters
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/localRules/{priority}/refreshCounters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalRules_refreshCounters</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> RefreshCountersAsync(string firewallName = null, CancellationToken cancellationToken = default)
        {
            using var scope = _localRulestackRuleLocalRulesClientDiagnostics.CreateScope("LocalRulestackRuleResource.RefreshCounters");
            scope.Start();
            try
            {
                var response = await _localRulestackRuleLocalRulesRestClient.RefreshCountersAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, firewallName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Refresh counters
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/localRules/{priority}/refreshCounters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalRules_refreshCounters</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response RefreshCounters(string firewallName = null, CancellationToken cancellationToken = default)
        {
            using var scope = _localRulestackRuleLocalRulesClientDiagnostics.CreateScope("LocalRulestackRuleResource.RefreshCounters");
            scope.Start();
            try
            {
                var response = _localRulestackRuleLocalRulesRestClient.RefreshCounters(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, firewallName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Reset counters
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/localRules/{priority}/resetCounters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalRules_resetCounters</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FirewallRuleResetConter>> ResetCountersAsync(string firewallName = null, CancellationToken cancellationToken = default)
        {
            using var scope = _localRulestackRuleLocalRulesClientDiagnostics.CreateScope("LocalRulestackRuleResource.ResetCounters");
            scope.Start();
            try
            {
                var response = await _localRulestackRuleLocalRulesRestClient.ResetCountersAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, firewallName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Reset counters
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/localRules/{priority}/resetCounters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalRules_resetCounters</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="firewallName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FirewallRuleResetConter> ResetCounters(string firewallName = null, CancellationToken cancellationToken = default)
        {
            using var scope = _localRulestackRuleLocalRulesClientDiagnostics.CreateScope("LocalRulestackRuleResource.ResetCounters");
            scope.Start();
            try
            {
                var response = _localRulestackRuleLocalRulesRestClient.ResetCounters(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, firewallName, cancellationToken);
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
