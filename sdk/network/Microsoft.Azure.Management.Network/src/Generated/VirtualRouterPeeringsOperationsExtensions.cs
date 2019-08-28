// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VirtualRouterPeeringsOperations.
    /// </summary>
    public static partial class VirtualRouterPeeringsOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified peering from a Virtual Router.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            public static void Delete(this IVirtualRouterPeeringsOperations operations, string peeringName)
            {
                operations.DeleteAsync(peeringName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified peering from a Virtual Router.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IVirtualRouterPeeringsOperations operations, string peeringName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(peeringName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the specified Virtual Router Peering.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the Virtual Router Peering.
            /// </param>
            public static VirtualRouterPeering Get(this IVirtualRouterPeeringsOperations operations, string peeringName)
            {
                return operations.GetAsync(peeringName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified Virtual Router Peering.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the Virtual Router Peering.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualRouterPeering> GetAsync(this IVirtualRouterPeeringsOperations operations, string peeringName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(peeringName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a Virtual Router Peering.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the Virtual Router Peering being updated.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to update Virtual Router Peering operation.
            /// </param>
            public static VirtualRouterPeering Update(this IVirtualRouterPeeringsOperations operations, string peeringName, VirtualRouterPeering parameters)
            {
                return operations.UpdateAsync(peeringName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a Virtual Router Peering.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the Virtual Router Peering being updated.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to update Virtual Router Peering operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualRouterPeering> UpdateAsync(this IVirtualRouterPeeringsOperations operations, string peeringName, VirtualRouterPeering parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(peeringName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the specified Virtual Router Peering.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the Virtual Router Peering.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update Virtual Router Peering
            /// operation.
            /// </param>
            public static VirtualRouterPeering CreateOrUpdate(this IVirtualRouterPeeringsOperations operations, string peeringName, VirtualRouterPeering parameters)
            {
                return operations.CreateOrUpdateAsync(peeringName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the specified Virtual Router Peering.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the Virtual Router Peering.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update Virtual Router Peering
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualRouterPeering> CreateOrUpdateAsync(this IVirtualRouterPeeringsOperations operations, string peeringName, VirtualRouterPeering parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(peeringName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all Virtual Router Peerings in a Virtual Router resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<VirtualRouterPeering> ListByResourceGroup(this IVirtualRouterPeeringsOperations operations)
            {
                return operations.ListByResourceGroupAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all Virtual Router Peerings in a Virtual Router resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualRouterPeering>> ListByResourceGroupAsync(this IVirtualRouterPeeringsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified peering from a Virtual Router.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            public static void BeginDelete(this IVirtualRouterPeeringsOperations operations, string peeringName)
            {
                operations.BeginDeleteAsync(peeringName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified peering from a Virtual Router.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IVirtualRouterPeeringsOperations operations, string peeringName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(peeringName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates the specified Virtual Router Peering.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the Virtual Router Peering.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update Virtual Router Peering
            /// operation.
            /// </param>
            public static VirtualRouterPeering BeginCreateOrUpdate(this IVirtualRouterPeeringsOperations operations, string peeringName, VirtualRouterPeering parameters)
            {
                return operations.BeginCreateOrUpdateAsync(peeringName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the specified Virtual Router Peering.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the Virtual Router Peering.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update Virtual Router Peering
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualRouterPeering> BeginCreateOrUpdateAsync(this IVirtualRouterPeeringsOperations operations, string peeringName, VirtualRouterPeering parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(peeringName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all Virtual Router Peerings in a Virtual Router resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VirtualRouterPeering> ListByResourceGroupNext(this IVirtualRouterPeeringsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all Virtual Router Peerings in a Virtual Router resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualRouterPeering>> ListByResourceGroupNextAsync(this IVirtualRouterPeeringsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
