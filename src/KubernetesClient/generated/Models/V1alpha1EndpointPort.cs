// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// EndpointPort represents a Port used by an EndpointSlice
    /// </summary>
    public partial class V1alpha1EndpointPort
    {
        /// <summary>
        /// Initializes a new instance of the V1alpha1EndpointPort class.
        /// </summary>
        public V1alpha1EndpointPort()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1alpha1EndpointPort class.
        /// </summary>
        /// <param name="name">The name of this port. All ports in an
        /// EndpointSlice must have a unique name. If the EndpointSlice is
        /// dervied from a Kubernetes service, this corresponds to the
        /// Service.ports[].name. Name must either be an empty string or pass
        /// IANA_SVC_NAME validation: * must be no more than 15 characters long
        /// * may contain only [-a-z0-9] * must contain at least one letter
        /// [a-z] * it must not start or end with a hyphen, nor contain
        /// adjacent hyphens Default is empty string.</param>
        /// <param name="port">The port number of the endpoint. If this is not
        /// specified, ports are not restricted and must be interpreted in the
        /// context of the specific consumer.</param>
        /// <param name="protocol">The IP protocol for this port. Must be UDP,
        /// TCP, or SCTP. Default is TCP.</param>
        public V1alpha1EndpointPort(string name = default(string), int? port = default(int?), string protocol = default(string))
        {
            Name = name;
            Port = port;
            Protocol = protocol;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of this port. All ports in an EndpointSlice
        /// must have a unique name. If the EndpointSlice is dervied from a
        /// Kubernetes service, this corresponds to the Service.ports[].name.
        /// Name must either be an empty string or pass IANA_SVC_NAME
        /// validation: * must be no more than 15 characters long * may contain
        /// only [-a-z0-9] * must contain at least one letter [a-z] * it must
        /// not start or end with a hyphen, nor contain adjacent hyphens
        /// Default is empty string.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the port number of the endpoint. If this is not
        /// specified, ports are not restricted and must be interpreted in the
        /// context of the specific consumer.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }

        /// <summary>
        /// Gets or sets the IP protocol for this port. Must be UDP, TCP, or
        /// SCTP. Default is TCP.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }

    }
}