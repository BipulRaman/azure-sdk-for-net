// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details about app recovery operation.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SnapshotRecoveryRequest : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the SnapshotRecoveryRequest class.
        /// </summary>
        public SnapshotRecoveryRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SnapshotRecoveryRequest class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="snapshotTime">Point in time in which the app recovery
        /// should be attempted, formatted as a DateTime string.</param>
        /// <param name="recoveryTarget">Specifies the web app that snapshot
        /// contents will be written to.</param>
        /// <param name="overwrite">If &lt;code&gt;true&lt;/code&gt; the
        /// recovery operation can overwrite source app; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="recoverConfiguration">If true, site configuration, in
        /// addition to content, will be reverted.</param>
        /// <param name="ignoreConflictingHostNames">If true, custom hostname
        /// conflicts will be ignored when recovering to a target web app.
        /// This setting is only necessary when RecoverConfiguration is
        /// enabled.</param>
        public SnapshotRecoveryRequest(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string snapshotTime = default(string), SnapshotRecoveryTarget recoveryTarget = default(SnapshotRecoveryTarget), bool? overwrite = default(bool?), bool? recoverConfiguration = default(bool?), bool? ignoreConflictingHostNames = default(bool?))
            : base(id, name, kind, type)
        {
            SnapshotTime = snapshotTime;
            RecoveryTarget = recoveryTarget;
            Overwrite = overwrite;
            RecoverConfiguration = recoverConfiguration;
            IgnoreConflictingHostNames = ignoreConflictingHostNames;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets point in time in which the app recovery should be
        /// attempted, formatted as a DateTime string.
        /// </summary>
        [JsonProperty(PropertyName = "properties.snapshotTime")]
        public string SnapshotTime { get; set; }

        /// <summary>
        /// Gets or sets specifies the web app that snapshot contents will be
        /// written to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.recoveryTarget")]
        public SnapshotRecoveryTarget RecoveryTarget { get; set; }

        /// <summary>
        /// Gets or sets if &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt; the
        /// recovery operation can overwrite source app; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.overwrite")]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// Gets or sets if true, site configuration, in addition to content,
        /// will be reverted.
        /// </summary>
        [JsonProperty(PropertyName = "properties.recoverConfiguration")]
        public bool? RecoverConfiguration { get; set; }

        /// <summary>
        /// Gets or sets if true, custom hostname conflicts will be ignored
        /// when recovering to a target web app.
        /// This setting is only necessary when RecoverConfiguration is
        /// enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ignoreConflictingHostNames")]
        public bool? IgnoreConflictingHostNames { get; set; }

    }
}
