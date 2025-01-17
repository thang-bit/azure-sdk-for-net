// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> The approval settings. </summary>
    public partial class RoleManagementApprovalSettings
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RoleManagementApprovalSettings"/>. </summary>
        public RoleManagementApprovalSettings()
        {
            ApprovalStages = new ChangeTrackingList<RoleManagementApprovalStage>();
        }

        /// <summary> Initializes a new instance of <see cref="RoleManagementApprovalSettings"/>. </summary>
        /// <param name="isApprovalRequired"> Determines whether approval is required or not. </param>
        /// <param name="isApprovalRequiredForExtension"> Determines whether approval is required for assignment extension. </param>
        /// <param name="isRequestorJustificationRequired"> Determine whether requestor justification is required. </param>
        /// <param name="approvalMode"> The type of rule. </param>
        /// <param name="approvalStages"> The approval stages of the request. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RoleManagementApprovalSettings(bool? isApprovalRequired, bool? isApprovalRequiredForExtension, bool? isRequestorJustificationRequired, RoleManagementApprovalMode? approvalMode, IList<RoleManagementApprovalStage> approvalStages, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsApprovalRequired = isApprovalRequired;
            IsApprovalRequiredForExtension = isApprovalRequiredForExtension;
            IsRequestorJustificationRequired = isRequestorJustificationRequired;
            ApprovalMode = approvalMode;
            ApprovalStages = approvalStages;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Determines whether approval is required or not. </summary>
        public bool? IsApprovalRequired { get; set; }
        /// <summary> Determines whether approval is required for assignment extension. </summary>
        public bool? IsApprovalRequiredForExtension { get; set; }
        /// <summary> Determine whether requestor justification is required. </summary>
        public bool? IsRequestorJustificationRequired { get; set; }
        /// <summary> The type of rule. </summary>
        public RoleManagementApprovalMode? ApprovalMode { get; set; }
        /// <summary> The approval stages of the request. </summary>
        public IList<RoleManagementApprovalStage> ApprovalStages { get; }
    }
}
