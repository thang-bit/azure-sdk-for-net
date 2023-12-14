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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a WebSiteTriggeredWebJobHistory along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="WebSiteTriggeredWebJobHistoryResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetWebSiteTriggeredWebJobHistoryResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteTriggeredwebJobResource"/> using the GetWebSiteTriggeredWebJobHistory method.
    /// </summary>
    public partial class WebSiteTriggeredWebJobHistoryResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WebSiteTriggeredWebJobHistoryResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="name"> The name. </param>
        /// <param name="webJobName"> The webJobName. </param>
        /// <param name="id"> The id. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string webJobName, string id)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history/{id}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _webSiteTriggeredWebJobHistoryWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSiteTriggeredWebJobHistoryWebAppsRestClient;
        private readonly TriggeredJobHistoryData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/triggeredwebjobs/history";

        /// <summary> Initializes a new instance of the <see cref="WebSiteTriggeredWebJobHistoryResource"/> class for mocking. </summary>
        protected WebSiteTriggeredWebJobHistoryResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteTriggeredWebJobHistoryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WebSiteTriggeredWebJobHistoryResource(ArmClient client, TriggeredJobHistoryData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteTriggeredWebJobHistoryResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WebSiteTriggeredWebJobHistoryResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteTriggeredWebJobHistoryWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string webSiteTriggeredWebJobHistoryWebAppsApiVersion);
            _webSiteTriggeredWebJobHistoryWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteTriggeredWebJobHistoryWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual TriggeredJobHistoryData Data
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
        /// Description for Gets a triggered web job's history by its ID for an app, , or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetTriggeredWebJobHistory</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<WebSiteTriggeredWebJobHistoryResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("WebSiteTriggeredWebJobHistoryResource.Get");
            scope.Start();
            try
            {
                var response = await _webSiteTriggeredWebJobHistoryWebAppsRestClient.GetTriggeredWebJobHistoryAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteTriggeredWebJobHistoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a triggered web job's history by its ID for an app, , or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetTriggeredWebJobHistory</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<WebSiteTriggeredWebJobHistoryResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("WebSiteTriggeredWebJobHistoryResource.Get");
            scope.Start();
            try
            {
                var response = _webSiteTriggeredWebJobHistoryWebAppsRestClient.GetTriggeredWebJobHistory(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteTriggeredWebJobHistoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
