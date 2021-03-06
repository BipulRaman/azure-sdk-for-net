// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters that can be used to update an existing Data Lake
    /// Analytics account.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DataLakeAnalyticsAccountUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsAccountUpdateParameters class.
        /// </summary>
        public DataLakeAnalyticsAccountUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsAccountUpdateParameters class.
        /// </summary>
        /// <param name="tags">Resource tags</param>
        /// <param name="maxDegreeOfParallelism">the maximum supported degree
        /// of parallelism for this account.</param>
        /// <param name="queryStoreRetention">the number of days that job
        /// metadata is retained.</param>
        /// <param name="maxJobCount">the maximum supported jobs running under
        /// the account at the same time.</param>
        /// <param name="newTier">the commitment tier to use for next month.
        /// Possible values include: 'Consumption', 'Commitment_100AUHours',
        /// 'Commitment_500AUHours', 'Commitment_1000AUHours',
        /// 'Commitment_5000AUHours', 'Commitment_10000AUHours',
        /// 'Commitment_50000AUHours', 'Commitment_100000AUHours',
        /// 'Commitment_500000AUHours'</param>
        /// <param name="firewallState">The current state of the IP address
        /// firewall for this Data Lake Analytics account. Possible values
        /// include: 'Enabled', 'Disabled'</param>
        /// <param name="firewallAllowAzureIps">The current state of allowing
        /// or disallowing IPs originating within Azure through the firewall.
        /// If the firewall is disabled, this is not enforced. Possible values
        /// include: 'Enabled', 'Disabled'</param>
        /// <param name="firewallRules">The list of firewall rules associated
        /// with this Data Lake Analytics account.</param>
        /// <param name="maxDegreeOfParallelismPerJob">the maximum supported
        /// degree of parallelism per job for this account.</param>
        /// <param name="minPriorityPerJob">the minimum supported priority per
        /// job for this account.</param>
        /// <param name="computePolicies">the list of existing compute policies
        /// to update in this account.</param>
        public DataLakeAnalyticsAccountUpdateParameters(IDictionary<string, string> tags = default(IDictionary<string, string>), int? maxDegreeOfParallelism = default(int?), int? queryStoreRetention = default(int?), int? maxJobCount = default(int?), TierType? newTier = default(TierType?), FirewallState? firewallState = default(FirewallState?), FirewallAllowAzureIpsState? firewallAllowAzureIps = default(FirewallAllowAzureIpsState?), IList<FirewallRule> firewallRules = default(IList<FirewallRule>), int? maxDegreeOfParallelismPerJob = default(int?), int? minPriorityPerJob = default(int?), IList<ComputePolicy> computePolicies = default(IList<ComputePolicy>))
        {
            Tags = tags;
            MaxDegreeOfParallelism = maxDegreeOfParallelism;
            QueryStoreRetention = queryStoreRetention;
            MaxJobCount = maxJobCount;
            NewTier = newTier;
            FirewallState = firewallState;
            FirewallAllowAzureIps = firewallAllowAzureIps;
            FirewallRules = firewallRules;
            MaxDegreeOfParallelismPerJob = maxDegreeOfParallelismPerJob;
            MinPriorityPerJob = minPriorityPerJob;
            ComputePolicies = computePolicies;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the maximum supported degree of parallelism for this
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxDegreeOfParallelism")]
        public int? MaxDegreeOfParallelism { get; set; }

        /// <summary>
        /// Gets or sets the number of days that job metadata is retained.
        /// </summary>
        [JsonProperty(PropertyName = "properties.queryStoreRetention")]
        public int? QueryStoreRetention { get; set; }

        /// <summary>
        /// Gets or sets the maximum supported jobs running under the account
        /// at the same time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxJobCount")]
        public int? MaxJobCount { get; set; }

        /// <summary>
        /// Gets or sets the commitment tier to use for next month. Possible
        /// values include: 'Consumption', 'Commitment_100AUHours',
        /// 'Commitment_500AUHours', 'Commitment_1000AUHours',
        /// 'Commitment_5000AUHours', 'Commitment_10000AUHours',
        /// 'Commitment_50000AUHours', 'Commitment_100000AUHours',
        /// 'Commitment_500000AUHours'
        /// </summary>
        [JsonProperty(PropertyName = "properties.newTier")]
        public TierType? NewTier { get; set; }

        /// <summary>
        /// Gets or sets the current state of the IP address firewall for this
        /// Data Lake Analytics account. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.firewallState")]
        public FirewallState? FirewallState { get; set; }

        /// <summary>
        /// Gets or sets the current state of allowing or disallowing IPs
        /// originating within Azure through the firewall. If the firewall is
        /// disabled, this is not enforced. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.firewallAllowAzureIps")]
        public FirewallAllowAzureIpsState? FirewallAllowAzureIps { get; set; }

        /// <summary>
        /// Gets or sets the list of firewall rules associated with this Data
        /// Lake Analytics account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.firewallRules")]
        public IList<FirewallRule> FirewallRules { get; set; }

        /// <summary>
        /// Gets or sets the maximum supported degree of parallelism per job
        /// for this account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxDegreeOfParallelismPerJob")]
        public int? MaxDegreeOfParallelismPerJob { get; set; }

        /// <summary>
        /// Gets or sets the minimum supported priority per job for this
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.minPriorityPerJob")]
        public int? MinPriorityPerJob { get; set; }

        /// <summary>
        /// Gets or sets the list of existing compute policies to update in
        /// this account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.computePolicies")]
        public IList<ComputePolicy> ComputePolicies { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MaxDegreeOfParallelism < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxDegreeOfParallelism", 1);
            }
            if (QueryStoreRetention > 180)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "QueryStoreRetention", 180);
            }
            if (QueryStoreRetention < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "QueryStoreRetention", 1);
            }
            if (MaxJobCount < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxJobCount", 1);
            }
            if (FirewallRules != null)
            {
                foreach (var element in FirewallRules)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (MaxDegreeOfParallelismPerJob < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxDegreeOfParallelismPerJob", 1);
            }
            if (MinPriorityPerJob < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MinPriorityPerJob", 1);
            }
            if (ComputePolicies != null)
            {
                foreach (var element1 in ComputePolicies)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
