// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Mutable configuration for notification. </summary>
    internal partial class PartialNotificationSetting
    {
        /// <summary> Initializes a new instance of <see cref="PartialNotificationSetting"/>. </summary>
        public PartialNotificationSetting()
        {
            Webhooks = new ChangeTrackingDictionary<string, MachineLearningWebhook>();
        }

        /// <summary> Initializes a new instance of <see cref="PartialNotificationSetting"/>. </summary>
        /// <param name="webhooks">
        /// Send webhook callback to a service. Key is a user-provided name for the webhook.
        /// Please note <see cref="MachineLearningWebhook"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureDevOpsWebhook"/>.
        /// </param>
        internal PartialNotificationSetting(IDictionary<string, MachineLearningWebhook> webhooks)
        {
            Webhooks = webhooks;
        }

        /// <summary>
        /// Send webhook callback to a service. Key is a user-provided name for the webhook.
        /// Please note <see cref="MachineLearningWebhook"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureDevOpsWebhook"/>.
        /// </summary>
        public IDictionary<string, MachineLearningWebhook> Webhooks { get; set; }
    }
}
