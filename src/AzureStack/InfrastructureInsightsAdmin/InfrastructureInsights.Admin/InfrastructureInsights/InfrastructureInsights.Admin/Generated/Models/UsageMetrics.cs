// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.AzureStack.Management.InfrastructureInsights.Admin.Models
{
    using Microsoft.AzureStack;
    using Microsoft.AzureStack.Management;
    using Microsoft.AzureStack.Management.InfrastructureInsights;
    using Microsoft.AzureStack.Management.InfrastructureInsights.Admin;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Metrics of resource usage.
    /// </summary>
    public partial class UsageMetrics
    {
        /// <summary>
        /// Initializes a new instance of the UsageMetrics class.
        /// </summary>
        public UsageMetrics()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UsageMetrics class.
        /// </summary>
        /// <param name="name">Name of the usage metric.</param>
        /// <param name="metricsValue">List of usage metrics.</param>
        public UsageMetrics(string name = default(string), IList<Metrics> metricsValue = default(IList<Metrics>))
        {
            Name = name;
            MetricsValue = metricsValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the usage metric.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets list of usage metrics.
        /// </summary>
        [JsonProperty(PropertyName = "metricsValue")]
        public IList<Metrics> MetricsValue { get; set; }

    }
}