// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace AutorestClient
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ReturnKeyValuePairRequest operations.
    /// </summary>
    public partial interface IReturnKeyValuePairRequest
    {
        /// <param name='body'>
        /// </param>
        /// <param name='format'>
        /// Specifies response output format
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="GetErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse<GetErrorModel>> GetWithHttpMessagesAsync(object body = default(object), string format = "json", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
