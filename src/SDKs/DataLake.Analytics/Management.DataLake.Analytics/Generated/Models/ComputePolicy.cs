// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Data Lake Analytics compute policy information.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ComputePolicy : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ComputePolicy class.
        /// </summary>
        public ComputePolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ComputePolicy class.
        /// </summary>
        /// <param name="id">The resource identifier.</param>
        /// <param name="name">The resource name.</param>
        /// <param name="type">The resource type.</param>
        /// <param name="objectId">The AAD object identifier for the entity to
        /// create a policy for.</param>
        /// <param name="objectType">The type of AAD object the object
        /// identifier refers to. Possible values include: 'User', 'Group',
        /// 'ServicePrincipal'</param>
        /// <param name="maxDegreeOfParallelismPerJob">The maximum degree of
        /// parallelism per job this user can use to submit jobs.</param>
        /// <param name="minPriorityPerJob">The minimum priority per job this
        /// user can use to submit jobs.</param>
        public ComputePolicy(string id = default(string), string name = default(string), string type = default(string), System.Guid? objectId = default(System.Guid?), string objectType = default(string), int? maxDegreeOfParallelismPerJob = default(int?), int? minPriorityPerJob = default(int?))
            : base(id, name, type)
        {
            ObjectId = objectId;
            ObjectType = objectType;
            MaxDegreeOfParallelismPerJob = maxDegreeOfParallelismPerJob;
            MinPriorityPerJob = minPriorityPerJob;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the AAD object identifier for the entity to create a policy
        /// for.
        /// </summary>
        [JsonProperty(PropertyName = "properties.objectId")]
        public System.Guid? ObjectId { get; private set; }

        /// <summary>
        /// Gets the type of AAD object the object identifier refers to.
        /// Possible values include: 'User', 'Group', 'ServicePrincipal'
        /// </summary>
        [JsonProperty(PropertyName = "properties.objectType")]
        public string ObjectType { get; private set; }

        /// <summary>
        /// Gets the maximum degree of parallelism per job this user can use to
        /// submit jobs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxDegreeOfParallelismPerJob")]
        public int? MaxDegreeOfParallelismPerJob { get; private set; }

        /// <summary>
        /// Gets the minimum priority per job this user can use to submit jobs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.minPriorityPerJob")]
        public int? MinPriorityPerJob { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MaxDegreeOfParallelismPerJob < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxDegreeOfParallelismPerJob", 1);
            }
            if (MinPriorityPerJob < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MinPriorityPerJob", 1);
            }
        }
    }
}
