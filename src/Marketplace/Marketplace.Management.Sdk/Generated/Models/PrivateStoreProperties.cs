// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Marketplace.Models
{
    using System.Linq;

    /// <summary>
    /// Describes the json payload on whether or not the private store is enabled
    /// for a given tenant
    /// </summary>
    public partial class PrivateStoreProperties
    {
        /// <summary>
        /// Initializes a new instance of the PrivateStoreProperties class.
        /// </summary>
        public PrivateStoreProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateStoreProperties class.
        /// </summary>

        /// <param name="availability">Indicates private store availability
        /// Possible values include: &#39;enabled&#39;, &#39;disabled&#39;</param>

        /// <param name="privateStoreId">Private Store id
        /// </param>

        /// <param name="eTag">Identifier for purposes of race condition
        /// </param>
        public PrivateStoreProperties(string availability = default(string), string privateStoreId = default(string), string eTag = default(string))

        {
            this.Availability = availability;
            this.PrivateStoreId = privateStoreId;
            this.ETag = eTag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets indicates private store availability Possible values include: &#39;enabled&#39;, &#39;disabled&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "availability")]
        public string Availability {get; set; }

        /// <summary>
        /// Gets or sets private Store id
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "privateStoreId")]
        public string PrivateStoreId {get; set; }

        /// <summary>
        /// Gets or sets identifier for purposes of race condition
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "eTag")]
        public string ETag {get; set; }
    }
}