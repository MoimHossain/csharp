// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// CSIStorageCapacity stores the result of one CSI GetCapacity call. For a
    /// given StorageClass, this describes the available capacity in a
    /// particular topology segment.  This can be used when considering where
    /// to instantiate new PersistentVolumes.
    ///
    /// For example this can express things like: - StorageClass "standard" has
    /// "1234 GiB" available in "topology.kubernetes.io/zone=us-east1" -
    /// StorageClass "localssd" has "10 GiB" available in
    /// "kubernetes.io/hostname=knode-abc123"
    ///
    /// The following three cases all imply that no capacity is available for a
    /// certain combination: - no object exists with suitable topology and
    /// storage class name - such an object exists, but the capacity is unset -
    /// such an object exists, but the capacity is zero
    ///
    /// The producer of these objects can decide which approach is more
    /// suitable.
    ///
    /// They are consumed by the kube-scheduler if the CSIStorageCapacity beta
    /// feature gate is enabled there and a CSI driver opts into capacity-aware
    /// scheduling with CSIDriver.StorageCapacity.
    /// </summary>
    public partial class V1alpha1CSIStorageCapacity
    {
        /// <summary>
        /// Initializes a new instance of the V1alpha1CSIStorageCapacity class.
        /// </summary>
        public V1alpha1CSIStorageCapacity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1alpha1CSIStorageCapacity class.
        /// </summary>
        /// <param name="storageClassName">The name of the StorageClass that
        /// the reported capacity applies to. It must meet the same
        /// requirements as the name of a StorageClass object (non-empty, DNS
        /// subdomain). If that object no longer exists, the CSIStorageCapacity
        /// object is obsolete and should be removed by its creator. This field
        /// is immutable.</param>
        /// <param name="apiVersion">APIVersion defines the versioned schema of
        /// this representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</param>
        /// <param name="capacity">Capacity is the value reported by the CSI
        /// driver in its GetCapacityResponse for a GetCapacityRequest with
        /// topology and parameters that match the previous fields.
        ///
        /// The semantic is currently (CSI spec 1.2) defined as: The available
        /// capacity, in bytes, of the storage that can be used to provision
        /// volumes. If not set, that information is currently unavailable and
        /// treated like zero capacity.</param>
        /// <param name="kind">Kind is a string value representing the REST
        /// resource this object represents. Servers may infer this from the
        /// endpoint the client submits requests to. Cannot be updated. In
        /// CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</param>
        /// <param name="maximumVolumeSize">MaximumVolumeSize is the value
        /// reported by the CSI driver in its GetCapacityResponse for a
        /// GetCapacityRequest with topology and parameters that match the
        /// previous fields.
        ///
        /// This is defined since CSI spec 1.4.0 as the largest size that may
        /// be used in a CreateVolumeRequest.capacity_range.required_bytes
        /// field to create a volume with the same parameters as those in
        /// GetCapacityRequest. The corresponding value in the Kubernetes API
        /// is ResourceRequirements.Requests in a volume claim.</param>
        /// <param name="metadata">Standard object's metadata. The name has no
        /// particular meaning. It must be be a DNS subdomain (dots allowed,
        /// 253 characters). To ensure that there are no conflicts with other
        /// CSI drivers on the cluster, the recommendation is to use
        /// csisc-&lt;uuid&gt;, a generated name, or a reverse-domain name
        /// which ends with the unique CSI driver name.
        ///
        /// Objects are namespaced.
        ///
        /// More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</param>
        /// <param name="nodeTopology">NodeTopology defines which nodes have
        /// access to the storage for which capacity was reported. If not set,
        /// the storage is not accessible from any node in the cluster. If
        /// empty, the storage is accessible from all nodes. This field is
        /// immutable.</param>
        public V1alpha1CSIStorageCapacity(string storageClassName, string apiVersion = default(string), ResourceQuantity capacity = default(ResourceQuantity), string kind = default(string), ResourceQuantity maximumVolumeSize = default(ResourceQuantity), V1ObjectMeta metadata = default(V1ObjectMeta), V1LabelSelector nodeTopology = default(V1LabelSelector))
        {
            ApiVersion = apiVersion;
            Capacity = capacity;
            Kind = kind;
            MaximumVolumeSize = maximumVolumeSize;
            Metadata = metadata;
            NodeTopology = nodeTopology;
            StorageClassName = storageClassName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets aPIVersion defines the versioned schema of this
        /// representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or sets capacity is the value reported by the CSI driver in
        /// its GetCapacityResponse for a GetCapacityRequest with topology and
        /// parameters that match the previous fields.
        ///
        /// The semantic is currently (CSI spec 1.2) defined as: The available
        /// capacity, in bytes, of the storage that can be used to provision
        /// volumes. If not set, that information is currently unavailable and
        /// treated like zero capacity.
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public ResourceQuantity Capacity { get; set; }

        /// <summary>
        /// Gets or sets kind is a string value representing the REST resource
        /// this object represents. Servers may infer this from the endpoint
        /// the client submits requests to. Cannot be updated. In CamelCase.
        /// More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets maximumVolumeSize is the value reported by the CSI
        /// driver in its GetCapacityResponse for a GetCapacityRequest with
        /// topology and parameters that match the previous fields.
        ///
        /// This is defined since CSI spec 1.4.0 as the largest size that may
        /// be used in a CreateVolumeRequest.capacity_range.required_bytes
        /// field to create a volume with the same parameters as those in
        /// GetCapacityRequest. The corresponding value in the Kubernetes API
        /// is ResourceRequirements.Requests in a volume claim.
        /// </summary>
        [JsonProperty(PropertyName = "maximumVolumeSize")]
        public ResourceQuantity MaximumVolumeSize { get; set; }

        /// <summary>
        /// Gets or sets standard object's metadata. The name has no particular
        /// meaning. It must be be a DNS subdomain (dots allowed, 253
        /// characters). To ensure that there are no conflicts with other CSI
        /// drivers on the cluster, the recommendation is to use
        /// csisc-&amp;lt;uuid&amp;gt;, a generated name, or a reverse-domain
        /// name which ends with the unique CSI driver name.
        ///
        /// Objects are namespaced.
        ///
        /// More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public V1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Gets or sets nodeTopology defines which nodes have access to the
        /// storage for which capacity was reported. If not set, the storage is
        /// not accessible from any node in the cluster. If empty, the storage
        /// is accessible from all nodes. This field is immutable.
        /// </summary>
        [JsonProperty(PropertyName = "nodeTopology")]
        public V1LabelSelector NodeTopology { get; set; }

        /// <summary>
        /// Gets or sets the name of the StorageClass that the reported
        /// capacity applies to. It must meet the same requirements as the name
        /// of a StorageClass object (non-empty, DNS subdomain). If that object
        /// no longer exists, the CSIStorageCapacity object is obsolete and
        /// should be removed by its creator. This field is immutable.
        /// </summary>
        [JsonProperty(PropertyName = "storageClassName")]
        public string StorageClassName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageClassName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageClassName");
            }
        }
    }
}