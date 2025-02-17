// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Maps.Models
{
    /// <summary> The set of keys which can be used to access the Maps REST APIs. Two keys are provided for key rotation without interruption. </summary>
    public partial class MapsAccountKeys
    {
        /// <summary> Initializes a new instance of MapsAccountKeys. </summary>
        internal MapsAccountKeys()
        {
        }

        /// <summary> Initializes a new instance of MapsAccountKeys. </summary>
        /// <param name="primaryKeyLastUpdatedOn"> The last updated date and time of the primary key. </param>
        /// <param name="primaryKey"> The primary key for accessing the Maps REST APIs. </param>
        /// <param name="secondaryKey"> The secondary key for accessing the Maps REST APIs. </param>
        /// <param name="secondaryKeyLastUpdatedOn"> The last updated date and time of the secondary key. </param>
        internal MapsAccountKeys(DateTimeOffset? primaryKeyLastUpdatedOn, string primaryKey, string secondaryKey, DateTimeOffset? secondaryKeyLastUpdatedOn)
        {
            PrimaryKeyLastUpdatedOn = primaryKeyLastUpdatedOn;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            SecondaryKeyLastUpdatedOn = secondaryKeyLastUpdatedOn;
        }

        /// <summary> The last updated date and time of the primary key. </summary>
        public DateTimeOffset? PrimaryKeyLastUpdatedOn { get; }
        /// <summary> The primary key for accessing the Maps REST APIs. </summary>
        public string PrimaryKey { get; }
        /// <summary> The secondary key for accessing the Maps REST APIs. </summary>
        public string SecondaryKey { get; }
        /// <summary> The last updated date and time of the secondary key. </summary>
        public DateTimeOffset? SecondaryKeyLastUpdatedOn { get; }
    }
}
