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
    /// VpnConnection Resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VpnConnection : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the VpnConnection class.
        /// </summary>
        public VpnConnection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VpnConnection class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="remoteVpnSite">Id of the connected vpn site.</param>
        /// <param name="routingWeight">Routing weight for vpn
        /// connection.</param>
        /// <param name="connectionStatus">The connection status. Possible
        /// values include: 'Unknown', 'Connecting', 'Connected',
        /// 'NotConnected'</param>
        /// <param name="vpnConnectionProtocolType">Connection protocol used
        /// for this connection. Possible values include: 'IKEv2',
        /// 'IKEv1'</param>
        /// <param name="ingressBytesTransferred">Ingress bytes
        /// transferred.</param>
        /// <param name="egressBytesTransferred">Egress bytes
        /// transferred.</param>
        /// <param name="connectionBandwidth">Expected bandwidth in
        /// MBPS.</param>
        /// <param name="sharedKey">SharedKey for the vpn connection.</param>
        /// <param name="enableBgp">EnableBgp flag.</param>
        /// <param name="usePolicyBasedTrafficSelectors">Enable policy-based
        /// traffic selectors.</param>
        /// <param name="ipsecPolicies">The IPSec Policies to be considered by
        /// this connection.</param>
        /// <param name="enableRateLimiting">EnableBgp flag.</param>
        /// <param name="enableInternetSecurity">Enable internet
        /// security.</param>
        /// <param name="useLocalAzureIpAddress">Use local azure ip to initiate
        /// connection.</param>
        /// <param name="provisioningState">The provisioning state of the VPN
        /// connection resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="vpnLinkConnections">List of all vpn site link
        /// connections to the gateway.</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">Gets a unique read-only string that changes
        /// whenever the resource is updated.</param>
        public VpnConnection(string id = default(string), SubResource remoteVpnSite = default(SubResource), int? routingWeight = default(int?), string connectionStatus = default(string), string vpnConnectionProtocolType = default(string), long? ingressBytesTransferred = default(long?), long? egressBytesTransferred = default(long?), int? connectionBandwidth = default(int?), string sharedKey = default(string), bool? enableBgp = default(bool?), bool? usePolicyBasedTrafficSelectors = default(bool?), IList<IpsecPolicy> ipsecPolicies = default(IList<IpsecPolicy>), bool? enableRateLimiting = default(bool?), bool? enableInternetSecurity = default(bool?), bool? useLocalAzureIpAddress = default(bool?), string provisioningState = default(string), IList<VpnSiteLinkConnection> vpnLinkConnections = default(IList<VpnSiteLinkConnection>), string name = default(string), string etag = default(string))
            : base(id)
        {
            RemoteVpnSite = remoteVpnSite;
            RoutingWeight = routingWeight;
            ConnectionStatus = connectionStatus;
            VpnConnectionProtocolType = vpnConnectionProtocolType;
            IngressBytesTransferred = ingressBytesTransferred;
            EgressBytesTransferred = egressBytesTransferred;
            ConnectionBandwidth = connectionBandwidth;
            SharedKey = sharedKey;
            EnableBgp = enableBgp;
            UsePolicyBasedTrafficSelectors = usePolicyBasedTrafficSelectors;
            IpsecPolicies = ipsecPolicies;
            EnableRateLimiting = enableRateLimiting;
            EnableInternetSecurity = enableInternetSecurity;
            UseLocalAzureIpAddress = useLocalAzureIpAddress;
            ProvisioningState = provisioningState;
            VpnLinkConnections = vpnLinkConnections;
            Name = name;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of the connected vpn site.
        /// </summary>
        [JsonProperty(PropertyName = "properties.remoteVpnSite")]
        public SubResource RemoteVpnSite { get; set; }

        /// <summary>
        /// Gets or sets routing weight for vpn connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.routingWeight")]
        public int? RoutingWeight { get; set; }

        /// <summary>
        /// Gets or sets the connection status. Possible values include:
        /// 'Unknown', 'Connecting', 'Connected', 'NotConnected'
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionStatus")]
        public string ConnectionStatus { get; set; }

        /// <summary>
        /// Gets or sets connection protocol used for this connection. Possible
        /// values include: 'IKEv2', 'IKEv1'
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnConnectionProtocolType")]
        public string VpnConnectionProtocolType { get; set; }

        /// <summary>
        /// Gets ingress bytes transferred.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ingressBytesTransferred")]
        public long? IngressBytesTransferred { get; private set; }

        /// <summary>
        /// Gets egress bytes transferred.
        /// </summary>
        [JsonProperty(PropertyName = "properties.egressBytesTransferred")]
        public long? EgressBytesTransferred { get; private set; }

        /// <summary>
        /// Gets or sets expected bandwidth in MBPS.
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionBandwidth")]
        public int? ConnectionBandwidth { get; set; }

        /// <summary>
        /// Gets or sets sharedKey for the vpn connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sharedKey")]
        public string SharedKey { get; set; }

        /// <summary>
        /// Gets or sets enableBgp flag.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableBgp")]
        public bool? EnableBgp { get; set; }

        /// <summary>
        /// Gets or sets enable policy-based traffic selectors.
        /// </summary>
        [JsonProperty(PropertyName = "properties.usePolicyBasedTrafficSelectors")]
        public bool? UsePolicyBasedTrafficSelectors { get; set; }

        /// <summary>
        /// Gets or sets the IPSec Policies to be considered by this
        /// connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipsecPolicies")]
        public IList<IpsecPolicy> IpsecPolicies { get; set; }

        /// <summary>
        /// Gets or sets enableBgp flag.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableRateLimiting")]
        public bool? EnableRateLimiting { get; set; }

        /// <summary>
        /// Gets or sets enable internet security.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableInternetSecurity")]
        public bool? EnableInternetSecurity { get; set; }

        /// <summary>
        /// Gets or sets use local azure ip to initiate connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.useLocalAzureIpAddress")]
        public bool? UseLocalAzureIpAddress { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state of the VPN connection resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets list of all vpn site link connections to the gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnLinkConnections")]
        public IList<VpnSiteLinkConnection> VpnLinkConnections { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within a
        /// resource group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}
