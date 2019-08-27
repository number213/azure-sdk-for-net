// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// ExpressRouteCircuit resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ExpressRouteCircuit : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuit class.
        /// </summary>
        public ExpressRouteCircuit()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuit class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="sku">The SKU.</param>
        /// <param name="allowClassicOperations">Allow classic
        /// operations.</param>
        /// <param name="circuitProvisioningState">The CircuitProvisioningState
        /// state of the resource.</param>
        /// <param name="serviceProviderProvisioningState">The
        /// ServiceProviderProvisioningState state of the resource. Possible
        /// values include: 'NotProvisioned', 'Provisioning', 'Provisioned',
        /// 'Deprovisioning'</param>
        /// <param name="authorizations">The list of authorizations.</param>
        /// <param name="peerings">The list of peerings.</param>
        /// <param name="serviceKey">The ServiceKey.</param>
        /// <param name="serviceProviderNotes">The
        /// ServiceProviderNotes.</param>
        /// <param name="serviceProviderProperties">The
        /// ServiceProviderProperties.</param>
        /// <param name="expressRoutePort">The reference to the
        /// ExpressRoutePort resource when the circuit is provisioned on an
        /// ExpressRoutePort resource.</param>
        /// <param name="bandwidthInGbps">The bandwidth of the circuit when the
        /// circuit is provisioned on an ExpressRoutePort resource.</param>
        /// <param name="stag">The identifier of the circuit traffic. Outer tag
        /// for QinQ encapsulation.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// express route circuit resource. Possible values include:
        /// 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="gatewayManagerEtag">The GatewayManager Etag.</param>
        /// <param name="globalReachEnabled">Flag denoting Global reach
        /// status.</param>
        /// <param name="etag">Gets a unique read-only string that changes
        /// whenever the resource is updated.</param>
        public ExpressRouteCircuit(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ExpressRouteCircuitSku sku = default(ExpressRouteCircuitSku), bool? allowClassicOperations = default(bool?), string circuitProvisioningState = default(string), string serviceProviderProvisioningState = default(string), IList<ExpressRouteCircuitAuthorization> authorizations = default(IList<ExpressRouteCircuitAuthorization>), IList<ExpressRouteCircuitPeering> peerings = default(IList<ExpressRouteCircuitPeering>), string serviceKey = default(string), string serviceProviderNotes = default(string), ExpressRouteCircuitServiceProviderProperties serviceProviderProperties = default(ExpressRouteCircuitServiceProviderProperties), SubResource expressRoutePort = default(SubResource), double? bandwidthInGbps = default(double?), int? stag = default(int?), string provisioningState = default(string), string gatewayManagerEtag = default(string), bool? globalReachEnabled = default(bool?), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            Sku = sku;
            AllowClassicOperations = allowClassicOperations;
            CircuitProvisioningState = circuitProvisioningState;
            ServiceProviderProvisioningState = serviceProviderProvisioningState;
            Authorizations = authorizations;
            Peerings = peerings;
            ServiceKey = serviceKey;
            ServiceProviderNotes = serviceProviderNotes;
            ServiceProviderProperties = serviceProviderProperties;
            ExpressRoutePort = expressRoutePort;
            BandwidthInGbps = bandwidthInGbps;
            Stag = stag;
            ProvisioningState = provisioningState;
            GatewayManagerEtag = gatewayManagerEtag;
            GlobalReachEnabled = globalReachEnabled;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the SKU.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public ExpressRouteCircuitSku Sku { get; set; }

        /// <summary>
        /// Gets or sets allow classic operations.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowClassicOperations")]
        public bool? AllowClassicOperations { get; set; }

        /// <summary>
        /// Gets or sets the CircuitProvisioningState state of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.circuitProvisioningState")]
        public string CircuitProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the ServiceProviderProvisioningState state of the
        /// resource. Possible values include: 'NotProvisioned',
        /// 'Provisioning', 'Provisioned', 'Deprovisioning'
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceProviderProvisioningState")]
        public string ServiceProviderProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the list of authorizations.
        /// </summary>
        [JsonProperty(PropertyName = "properties.authorizations")]
        public IList<ExpressRouteCircuitAuthorization> Authorizations { get; set; }

        /// <summary>
        /// Gets or sets the list of peerings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peerings")]
        public IList<ExpressRouteCircuitPeering> Peerings { get; set; }

        /// <summary>
        /// Gets or sets the ServiceKey.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceKey")]
        public string ServiceKey { get; set; }

        /// <summary>
        /// Gets or sets the ServiceProviderNotes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceProviderNotes")]
        public string ServiceProviderNotes { get; set; }

        /// <summary>
        /// Gets or sets the ServiceProviderProperties.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceProviderProperties")]
        public ExpressRouteCircuitServiceProviderProperties ServiceProviderProperties { get; set; }

        /// <summary>
        /// Gets or sets the reference to the ExpressRoutePort resource when
        /// the circuit is provisioned on an ExpressRoutePort resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expressRoutePort")]
        public SubResource ExpressRoutePort { get; set; }

        /// <summary>
        /// Gets or sets the bandwidth of the circuit when the circuit is
        /// provisioned on an ExpressRoutePort resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.bandwidthInGbps")]
        public double? BandwidthInGbps { get; set; }

        /// <summary>
        /// Gets the identifier of the circuit traffic. Outer tag for QinQ
        /// encapsulation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.stag")]
        public int? Stag { get; private set; }

        /// <summary>
        /// Gets or sets the provisioning state of the express route circuit
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the GatewayManager Etag.
        /// </summary>
        [JsonProperty(PropertyName = "properties.gatewayManagerEtag")]
        public string GatewayManagerEtag { get; set; }

        /// <summary>
        /// Gets or sets flag denoting Global reach status.
        /// </summary>
        [JsonProperty(PropertyName = "properties.globalReachEnabled")]
        public bool? GlobalReachEnabled { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}
