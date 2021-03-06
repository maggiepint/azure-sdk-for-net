// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Policy.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Policy : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Policy class.
        /// </summary>
        public Policy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Policy class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="reservationPurchasesAllowed">The
        /// reservationPurchasesAllowed flag.</param>
        /// <param name="marketplacePurchasesAllowed">The
        /// marketplacePurchasesAllowed flag.</param>
        public Policy(string id = default(string), string name = default(string), string type = default(string), bool? reservationPurchasesAllowed = default(bool?), bool? marketplacePurchasesAllowed = default(bool?))
            : base(id, name, type)
        {
            ReservationPurchasesAllowed = reservationPurchasesAllowed;
            MarketplacePurchasesAllowed = marketplacePurchasesAllowed;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the reservationPurchasesAllowed flag.
        /// </summary>
        [JsonProperty(PropertyName = "properties.reservationPurchasesAllowed")]
        public bool? ReservationPurchasesAllowed { get; set; }

        /// <summary>
        /// Gets or sets the marketplacePurchasesAllowed flag.
        /// </summary>
        [JsonProperty(PropertyName = "properties.marketplacePurchasesAllowed")]
        public bool? MarketplacePurchasesAllowed { get; set; }

    }
}
