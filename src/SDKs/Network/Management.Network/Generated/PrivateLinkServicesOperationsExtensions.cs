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
    /// Extension methods for PrivateLinkServicesOperations.
    /// </summary>
    public static partial class PrivateLinkServicesOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified private link service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the private link service.
            /// </param>
            public static void Delete(this IPrivateLinkServicesOperations operations, string resourceGroupName, string serviceName)
            {
                operations.DeleteAsync(resourceGroupName, serviceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified private link service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the private link service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPrivateLinkServicesOperations operations, string resourceGroupName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the specified private link service by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the private link service.
            /// </param>
            /// <param name='expand'>
            /// Expands referenced resources.
            /// </param>
            public static PrivateLinkService Get(this IPrivateLinkServicesOperations operations, string resourceGroupName, string serviceName, string expand = default(string))
            {
                return operations.GetAsync(resourceGroupName, serviceName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified private link service by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the private link service.
            /// </param>
            /// <param name='expand'>
            /// Expands referenced resources.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateLinkService> GetAsync(this IPrivateLinkServicesOperations operations, string resourceGroupName, string serviceName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an private link service in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the private link service.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update private link service operation
            /// </param>
            public static PrivateLinkService CreateOrUpdate(this IPrivateLinkServicesOperations operations, string resourceGroupName, string serviceName, PrivateLinkService parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an private link service in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the private link service.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update private link service operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateLinkService> CreateOrUpdateAsync(this IPrivateLinkServicesOperations operations, string resourceGroupName, string serviceName, PrivateLinkService parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all private link services in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<PrivateLinkService> List(this IPrivateLinkServicesOperations operations, string resourceGroupName)
            {
                return operations.ListAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all private link services in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PrivateLinkService>> ListAsync(this IPrivateLinkServicesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all private link service in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<PrivateLinkService> ListBySubscription(this IPrivateLinkServicesOperations operations)
            {
                return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all private link service in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PrivateLinkService>> ListBySubscriptionAsync(this IPrivateLinkServicesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Approve or reject private end point connection for a private link service
            /// in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the private link service.
            /// </param>
            /// <param name='peConnectionName'>
            /// The name of the private end point connection.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to approve or reject the private end point connection.
            /// </param>
            public static void UpdatePrivateEndpointConnection(this IPrivateLinkServicesOperations operations, string resourceGroupName, string serviceName, string peConnectionName, PrivateLinkService parameters)
            {
                operations.UpdatePrivateEndpointConnectionAsync(resourceGroupName, serviceName, peConnectionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Approve or reject private end point connection for a private link service
            /// in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the private link service.
            /// </param>
            /// <param name='peConnectionName'>
            /// The name of the private end point connection.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to approve or reject the private end point connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdatePrivateEndpointConnectionAsync(this IPrivateLinkServicesOperations operations, string resourceGroupName, string serviceName, string peConnectionName, PrivateLinkService parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdatePrivateEndpointConnectionWithHttpMessagesAsync(resourceGroupName, serviceName, peConnectionName, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete private end point connection for a private link service in a
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the private link service.
            /// </param>
            /// <param name='peConnectionName'>
            /// The name of the private end point connection.
            /// </param>
            public static void DeletePrivateEndpointConnection(this IPrivateLinkServicesOperations operations, string resourceGroupName, string serviceName, string peConnectionName)
            {
                operations.DeletePrivateEndpointConnectionAsync(resourceGroupName, serviceName, peConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete private end point connection for a private link service in a
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the private link service.
            /// </param>
            /// <param name='peConnectionName'>
            /// The name of the private end point connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeletePrivateEndpointConnectionAsync(this IPrivateLinkServicesOperations operations, string resourceGroupName, string serviceName, string peConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeletePrivateEndpointConnectionWithHttpMessagesAsync(resourceGroupName, serviceName, peConnectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deletes the specified private link service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the private link service.
            /// </param>
            public static void BeginDelete(this IPrivateLinkServicesOperations operations, string resourceGroupName, string serviceName)
            {
                operations.BeginDeleteAsync(resourceGroupName, serviceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified private link service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the private link service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IPrivateLinkServicesOperations operations, string resourceGroupName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, serviceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates an private link service in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the private link service.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update private link service operation
            /// </param>
            public static PrivateLinkService BeginCreateOrUpdate(this IPrivateLinkServicesOperations operations, string resourceGroupName, string serviceName, PrivateLinkService parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serviceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an private link service in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the private link service.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update private link service operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateLinkService> BeginCreateOrUpdateAsync(this IPrivateLinkServicesOperations operations, string resourceGroupName, string serviceName, PrivateLinkService parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all private link services in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PrivateLinkService> ListNext(this IPrivateLinkServicesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all private link services in a resource group.
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
            public static async Task<IPage<PrivateLinkService>> ListNextAsync(this IPrivateLinkServicesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all private link service in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PrivateLinkService> ListBySubscriptionNext(this IPrivateLinkServicesOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all private link service in a subscription.
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
            public static async Task<IPage<PrivateLinkService>> ListBySubscriptionNextAsync(this IPrivateLinkServicesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
