// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.OperationalInsights
{
    using Azure;
    using Management;
    using Rest;
    using Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Azure Log Analytics API reference
    /// </summary>
    public partial interface IAzureLogAnalyticsClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running
        /// Operations. Default value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is generated
        /// and included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the ILinkedServicesOperations.
        /// </summary>
        ILinkedServicesOperations LinkedServices { get; }

        /// <summary>
        /// Gets the IDataSourcesOperations.
        /// </summary>
        IDataSourcesOperations DataSources { get; }

        /// <summary>
        /// Gets the IWorkspacesOperations.
        /// </summary>
        IWorkspacesOperations Workspaces { get; }

        /// <summary>
        /// Gets the IStorageInsightsOperations.
        /// </summary>
        IStorageInsightsOperations StorageInsights { get; }

        /// <summary>
        /// Gets the ISavedSearchesOperations.
        /// </summary>
        ISavedSearchesOperations SavedSearches { get; }

    }
}
