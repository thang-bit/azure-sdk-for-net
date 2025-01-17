// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> The UnknownFilter. </summary>
    internal partial class UnknownFilter : EventGridFilter
    {
        /// <summary> Initializes a new instance of <see cref="UnknownFilter"/>. </summary>
        /// <param name="operatorType"> The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others. </param>
        /// <param name="key"> The field/property in the event based on which you want to filter. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownFilter(FilterOperatorType operatorType, string key, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(operatorType, key, serializedAdditionalRawData)
        {
            OperatorType = operatorType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownFilter"/> for deserialization. </summary>
        internal UnknownFilter()
        {
        }
    }
}
