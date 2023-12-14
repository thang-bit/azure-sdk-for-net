// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Properties of the topic spaces configuration info of a namespace. </summary>
    public partial class UpdateTopicSpacesConfigurationInfo
    {
        /// <summary> Initializes a new instance of <see cref="UpdateTopicSpacesConfigurationInfo"/>. </summary>
        public UpdateTopicSpacesConfigurationInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="UpdateTopicSpacesConfigurationInfo"/>. </summary>
        /// <param name="state"> Indicate if Topic Spaces Configuration is enabled for the namespace. Default is Disabled. </param>
        /// <param name="routeTopicResourceId"> This property is used to specify custom topic to which events will be routed to from topic spaces configuration under namespace. </param>
        /// <param name="routingEnrichments"> Routing enrichments for topic spaces configuration. </param>
        /// <param name="clientAuthentication"> Client authentication settings for topic spaces configuration. </param>
        /// <param name="maximumSessionExpiryInHours">
        /// The maximum session expiry in hours. The property default value is 1 hour.
        /// Min allowed value is 1 hour and max allowed value is 8 hours.
        /// </param>
        /// <param name="maximumClientSessionsPerAuthenticationName">
        /// The maximum number of sessions per authentication name. The property default value is 1.
        /// Min allowed value is 1 and max allowed value is 100.
        /// </param>
        /// <param name="routingIdentityInfo"> Routing identity info for topic spaces configuration. </param>
        internal UpdateTopicSpacesConfigurationInfo(TopicSpacesConfigurationState? state, string routeTopicResourceId, RoutingEnrichments routingEnrichments, ClientAuthenticationSettings clientAuthentication, int? maximumSessionExpiryInHours, int? maximumClientSessionsPerAuthenticationName, RoutingIdentityInfo routingIdentityInfo)
        {
            State = state;
            RouteTopicResourceId = routeTopicResourceId;
            RoutingEnrichments = routingEnrichments;
            ClientAuthentication = clientAuthentication;
            MaximumSessionExpiryInHours = maximumSessionExpiryInHours;
            MaximumClientSessionsPerAuthenticationName = maximumClientSessionsPerAuthenticationName;
            RoutingIdentityInfo = routingIdentityInfo;
        }

        /// <summary> Indicate if Topic Spaces Configuration is enabled for the namespace. Default is Disabled. </summary>
        public TopicSpacesConfigurationState? State { get; set; }
        /// <summary> This property is used to specify custom topic to which events will be routed to from topic spaces configuration under namespace. </summary>
        public string RouteTopicResourceId { get; set; }
        /// <summary> Routing enrichments for topic spaces configuration. </summary>
        public RoutingEnrichments RoutingEnrichments { get; set; }
        /// <summary> Client authentication settings for topic spaces configuration. </summary>
        internal ClientAuthenticationSettings ClientAuthentication { get; set; }
        /// <summary> Alternative authentication name sources related to client authentication settings for namespace resource. </summary>
        public IList<AlternativeAuthenticationNameSource> AlternativeAuthenticationNameSources
        {
            get
            {
                if (ClientAuthentication is null)
                    ClientAuthentication = new ClientAuthenticationSettings();
                return ClientAuthentication.AlternativeAuthenticationNameSources;
            }
        }

        /// <summary>
        /// The maximum session expiry in hours. The property default value is 1 hour.
        /// Min allowed value is 1 hour and max allowed value is 8 hours.
        /// </summary>
        public int? MaximumSessionExpiryInHours { get; set; }
        /// <summary>
        /// The maximum number of sessions per authentication name. The property default value is 1.
        /// Min allowed value is 1 and max allowed value is 100.
        /// </summary>
        public int? MaximumClientSessionsPerAuthenticationName { get; set; }
        /// <summary> Routing identity info for topic spaces configuration. </summary>
        public RoutingIdentityInfo RoutingIdentityInfo { get; set; }
    }
}
