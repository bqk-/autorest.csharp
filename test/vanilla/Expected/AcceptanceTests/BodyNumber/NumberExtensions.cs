// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.AcceptanceTestsBodyNumber
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Number.
    /// </summary>
    public static partial class NumberExtensions
    {
            /// <summary>
            /// Get null Number value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static double? GetNull(this INumber operations)
            {
                return operations.GetNullAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get null Number value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<double?> GetNullAsync(this INumber operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetNullWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get invalid float Number value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static double? GetInvalidFloat(this INumber operations)
            {
                return operations.GetInvalidFloatAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get invalid float Number value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<double?> GetInvalidFloatAsync(this INumber operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetInvalidFloatWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get invalid double Number value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static double? GetInvalidDouble(this INumber operations)
            {
                return operations.GetInvalidDoubleAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get invalid double Number value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<double?> GetInvalidDoubleAsync(this INumber operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetInvalidDoubleWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put big float value 3.402823e+20
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='numberBody'>
            /// </param>
            public static void PutBigFloat(this INumber operations, double numberBody)
            {
                operations.PutBigFloatAsync(numberBody).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put big float value 3.402823e+20
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='numberBody'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutBigFloatAsync(this INumber operations, double numberBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutBigFloatWithHttpMessagesAsync(numberBody, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get big float value 3.402823e+20
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static double? GetBigFloat(this INumber operations)
            {
                return operations.GetBigFloatAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get big float value 3.402823e+20
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<double?> GetBigFloatAsync(this INumber operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetBigFloatWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put big double value 2.5976931e+101
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='numberBody'>
            /// </param>
            public static void PutBigDouble(this INumber operations, double numberBody)
            {
                operations.PutBigDoubleAsync(numberBody).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put big double value 2.5976931e+101
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='numberBody'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutBigDoubleAsync(this INumber operations, double numberBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutBigDoubleWithHttpMessagesAsync(numberBody, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get big double value 2.5976931e+101
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static double? GetBigDouble(this INumber operations)
            {
                return operations.GetBigDoubleAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get big double value 2.5976931e+101
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<double?> GetBigDoubleAsync(this INumber operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetBigDoubleWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put big double value 99999999.99
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void PutBigDoublePositiveDecimal(this INumber operations)
            {
                operations.PutBigDoublePositiveDecimalAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put big double value 99999999.99
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutBigDoublePositiveDecimalAsync(this INumber operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutBigDoublePositiveDecimalWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get big double value 99999999.99
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static double? GetBigDoublePositiveDecimal(this INumber operations)
            {
                return operations.GetBigDoublePositiveDecimalAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get big double value 99999999.99
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<double?> GetBigDoublePositiveDecimalAsync(this INumber operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetBigDoublePositiveDecimalWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put big double value -99999999.99
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void PutBigDoubleNegativeDecimal(this INumber operations)
            {
                operations.PutBigDoubleNegativeDecimalAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put big double value -99999999.99
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutBigDoubleNegativeDecimalAsync(this INumber operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutBigDoubleNegativeDecimalWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get big double value -99999999.99
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static double? GetBigDoubleNegativeDecimal(this INumber operations)
            {
                return operations.GetBigDoubleNegativeDecimalAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get big double value -99999999.99
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<double?> GetBigDoubleNegativeDecimalAsync(this INumber operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetBigDoubleNegativeDecimalWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put small float value 3.402823e-20
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='numberBody'>
            /// </param>
            public static void PutSmallFloat(this INumber operations, double numberBody)
            {
                operations.PutSmallFloatAsync(numberBody).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put small float value 3.402823e-20
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='numberBody'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutSmallFloatAsync(this INumber operations, double numberBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutSmallFloatWithHttpMessagesAsync(numberBody, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get big double value 3.402823e-20
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static double? GetSmallFloat(this INumber operations)
            {
                return operations.GetSmallFloatAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get big double value 3.402823e-20
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<double?> GetSmallFloatAsync(this INumber operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSmallFloatWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put small double value 2.5976931e-101
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='numberBody'>
            /// </param>
            public static void PutSmallDouble(this INumber operations, double numberBody)
            {
                operations.PutSmallDoubleAsync(numberBody).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put small double value 2.5976931e-101
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='numberBody'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutSmallDoubleAsync(this INumber operations, double numberBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutSmallDoubleWithHttpMessagesAsync(numberBody, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get big double value 2.5976931e-101
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static double? GetSmallDouble(this INumber operations)
            {
                return operations.GetSmallDoubleAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get big double value 2.5976931e-101
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<double?> GetSmallDoubleAsync(this INumber operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSmallDoubleWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
