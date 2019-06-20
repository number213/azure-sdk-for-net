// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServerManagement.Models
{
    using System.Linq;

    /// <summary>
    /// the session object
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class SessionResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the SessionResource class.
        /// </summary>
        public SessionResource() { }

        /// <summary>
        /// Initializes a new instance of the SessionResource class.
        /// </summary>
        /// <param name="id">ARM Resource ID</param>
        /// <param name="type">ARM Resource Type</param>
        /// <param name="name">ARM Resource Name</param>
        /// <param name="location">ARM Resource Location</param>
        /// <param name="tags">ARM Resource Tags</param>
        /// <param name="userName">the username connecting to the
        /// session</param>
        /// <param name="created">UTC date and time when node was first added
        /// to management service</param>
        /// <param name="updated">UTC date and time when node was last
        /// updated.</param>
        public SessionResource(string id = default(string), string type = default(string), string name = default(string), string location = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string etag = default(string), string userName = default(string), System.DateTime? created = default(System.DateTime?), System.DateTime? updated = default(System.DateTime?))
            : base(id, type, name, location, tags, etag)
        {
            UserName = userName;
            Created = created;
            Updated = updated;
        }

        /// <summary>
        /// Gets or sets the username connecting to the session
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.userName")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets UTC date and time when node was first added to
        /// management service
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.created")]
        public System.DateTime? Created { get; set; }

        /// <summary>
        /// Gets or sets UTC date and time when node was last updated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.updated")]
        public System.DateTime? Updated { get; set; }

    }
}