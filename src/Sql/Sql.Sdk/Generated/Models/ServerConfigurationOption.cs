// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A server configuration option
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ServerConfigurationOption : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the ServerConfigurationOption class.
        /// </summary>
        public ServerConfigurationOption()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerConfigurationOption class.
        /// </summary>
        /// <param name="serverConfigurationOptionValue">Value of the server
        /// configuration option.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="provisioningState">Provisioning state of server
        /// configuration option. Possible values include: 'Created',
        /// 'InProgress', 'Succeeded', 'Failed', 'Canceled'</param>
        public ServerConfigurationOption(int serverConfigurationOptionValue, string id = default(string), string name = default(string), string type = default(string), string provisioningState = default(string))
            : base(id, name, type)
        {
            ServerConfigurationOptionValue = serverConfigurationOptionValue;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets value of the server configuration option.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serverConfigurationOptionValue")]
        public int ServerConfigurationOptionValue { get; set; }

        /// <summary>
        /// Gets provisioning state of server configuration option. Possible
        /// values include: 'Created', 'InProgress', 'Succeeded', 'Failed',
        /// 'Canceled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
