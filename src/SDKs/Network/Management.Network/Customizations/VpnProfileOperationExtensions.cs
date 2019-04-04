using System;

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public static partial class VirtualNetworkGatewaysOperationsExtensions
    {
        /// <summary>
        /// Generates VPN profile for P2S client of the virtual network gateway in the
        /// specified resource group. Used for IKEV2 and radius based authentication.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkGatewayName'>
        /// The name of the virtual network gateway.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the generate virtual network gateway VPN client
        /// package operation.
        /// </param>
        public static string GenerateGatewayVpnProfile(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName, VpnClientParameters parameters)
        {
            return GenerateVpnProfile(operations, resourceGroupName, virtualNetworkGatewayName, parameters);
        }

        /// <summary>
        /// Gets pre-generated VPN profile for P2S client of the virtual network
        /// gateway in the specified resource group. The profile needs to be generated
        /// first using generateVpnProfile.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='virtualNetworkGatewayName'>
        /// The name of the virtual network gateway.
        /// </param>
        public static string GetGatewayVpnProfile(this IVirtualNetworkGatewaysOperations operations, string resourceGroupName, string virtualNetworkGatewayName)
        {
            return GetVpnProfilePackageUrl(operations, resourceGroupName, virtualNetworkGatewayName);
        }
    }
}
