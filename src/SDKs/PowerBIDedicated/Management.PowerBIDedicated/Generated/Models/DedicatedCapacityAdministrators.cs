// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 2.2.27.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PowerBIDedicated.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An array of administrator user identities
    /// </summary>
    public partial class DedicatedCapacityAdministrators
    {
        /// <summary>
        /// Initializes a new instance of the DedicatedCapacityAdministrators
        /// class.
        /// </summary>
        public DedicatedCapacityAdministrators()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DedicatedCapacityAdministrators
        /// class.
        /// </summary>
        /// <param name="members">An array of administrator user
        /// identities.</param>
        public DedicatedCapacityAdministrators(IList<string> members = default(IList<string>))
        {
            Members = members;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an array of administrator user identities.
        /// </summary>
        [JsonProperty(PropertyName = "members")]
        public IList<string> Members { get; set; }

    }
}
