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
    /// Virtual Network Tap resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualNetworkTap : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkTap class.
        /// </summary>
        public VirtualNetworkTap()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkTap class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="networkInterfaceTapConfigurations">Specifies the list
        /// of resource IDs for the network interface IP configuration that
        /// needs to be tapped.</param>
        /// <param name="resourceGuid">The resourceGuid property of the virtual
        /// network tap.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// virtual network tap resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="destinationNetworkInterfaceIPConfiguration">The
        /// reference to the private IP Address of the collector nic that will
        /// receive the tap.</param>
        /// <param name="destinationLoadBalancerFrontEndIPConfiguration">The
        /// reference to the private IP address on the internal Load Balancer
        /// that will receive the tap.</param>
        /// <param name="destinationPort">The VXLAN destination port that will
        /// receive the tapped traffic.</param>
        /// <param name="etag">Gets a unique read-only string that changes
        /// whenever the resource is updated.</param>
        public VirtualNetworkTap(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<NetworkInterfaceTapConfiguration> networkInterfaceTapConfigurations = default(IList<NetworkInterfaceTapConfiguration>), string resourceGuid = default(string), string provisioningState = default(string), NetworkInterfaceIPConfiguration destinationNetworkInterfaceIPConfiguration = default(NetworkInterfaceIPConfiguration), FrontendIPConfiguration destinationLoadBalancerFrontEndIPConfiguration = default(FrontendIPConfiguration), int? destinationPort = default(int?), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            NetworkInterfaceTapConfigurations = networkInterfaceTapConfigurations;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            DestinationNetworkInterfaceIPConfiguration = destinationNetworkInterfaceIPConfiguration;
            DestinationLoadBalancerFrontEndIPConfiguration = destinationLoadBalancerFrontEndIPConfiguration;
            DestinationPort = destinationPort;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets specifies the list of resource IDs for the network interface
        /// IP configuration that needs to be tapped.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkInterfaceTapConfigurations")]
        public IList<NetworkInterfaceTapConfiguration> NetworkInterfaceTapConfigurations { get; private set; }

        /// <summary>
        /// Gets the resourceGuid property of the virtual network tap.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the virtual network tap resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the reference to the private IP Address of the
        /// collector nic that will receive the tap.
        /// </summary>
        [JsonProperty(PropertyName = "properties.destinationNetworkInterfaceIPConfiguration")]
        public NetworkInterfaceIPConfiguration DestinationNetworkInterfaceIPConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the reference to the private IP address on the
        /// internal Load Balancer that will receive the tap.
        /// </summary>
        [JsonProperty(PropertyName = "properties.destinationLoadBalancerFrontEndIPConfiguration")]
        public FrontendIPConfiguration DestinationLoadBalancerFrontEndIPConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the VXLAN destination port that will receive the
        /// tapped traffic.
        /// </summary>
        [JsonProperty(PropertyName = "properties.destinationPort")]
        public int? DestinationPort { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
