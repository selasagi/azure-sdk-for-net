// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{
    using Azure;
    using Management;
    using Azure;
    using Management;
    using Storage;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Storage;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for State.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum State
    {
        [EnumMember(Value = "provisioning")]
        Provisioning,
        [EnumMember(Value = "deprovisioning")]
        Deprovisioning,
        [EnumMember(Value = "succeeded")]
        Succeeded,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "networkSourceDeleted")]
        NetworkSourceDeleted
    }
}

