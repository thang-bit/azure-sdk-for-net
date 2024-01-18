// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> Unknown version of DataConnection. </summary>
    internal partial class UnknownDataConnection : DataConnection
    {
        /// <summary> Initializes a new instance of <see cref="UnknownDataConnection"/>. </summary>
        /// <param name="kind"> Discriminator. </param>
        /// <param name="id"> The system generated unique id for the resource. </param>
        /// <param name="name"> The caller provided unique name for the resource. </param>
        /// <param name="displayName"> The name that can be used for display purposes. </param>
        /// <param name="content"> The type of data the data connection will transfer. </param>
        /// <param name="createdDate"> The date the data connection was created. </param>
        /// <param name="frequency"> The rate at which the data connection will receive updates. </param>
        /// <param name="frequencyOffset"> The day to update the data connection on. </param>
        /// <param name="updatedDate"> The date the data connection was last updated. </param>
        /// <param name="userUpdatedAt"> The date the data connection was last updated by user. </param>
        /// <param name="active"> An indicator of whether the data connection is active. </param>
        /// <param name="inactiveMessage"> A message that specifies details about data connection if inactive. </param>
        internal UnknownDataConnection(string kind, string id, string name, string displayName, DataConnectionContent? content, DateTimeOffset? createdDate, DataConnectionFrequency? frequency, int? frequencyOffset, DateTimeOffset? updatedDate, DateTimeOffset? userUpdatedAt, bool? active, string inactiveMessage) : base(kind, id, name, displayName, content, createdDate, frequency, frequencyOffset, updatedDate, userUpdatedAt, active, inactiveMessage)
        {
        }
    }
}
