// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Openapi
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// </summary>
    public partial interface IOpenAPI : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Client API version.
        /// </summary>
        string ApiVersion { get; }


        /// <summary>
        /// Register new patient
        /// </summary>
        /// <param name='code'>
        /// </param>
        /// <param name='isvalid2'>
        /// </param>
        /// <param name='address1'>
        /// Patient's address - 1st line (Max length: 100)
        /// </param>
        /// <param name='address2'>
        /// Patient's address - 2nd line (Max length: 100)
        /// </param>
        /// <param name='city'>
        /// Patient's city (Max length: 30)
        /// </param>
        /// <param name='departmentid'>
        /// </param>
        /// <param name='isvalid'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> CreatePatientWithHttpMessagesAsync(int code, bool isvalid2, string address1 = default(string), string address2 = default(string), string city = default(string), int? departmentid = default(int?), bool? isvalid = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}