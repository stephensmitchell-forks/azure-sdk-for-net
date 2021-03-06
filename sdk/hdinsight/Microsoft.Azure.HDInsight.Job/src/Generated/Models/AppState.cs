// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.HDInsight.Job.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The State of the application.
    /// </summary>
    public partial class AppState
    {
        /// <summary>
        /// Initializes a new instance of the AppState class.
        /// </summary>
        public AppState()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AppState class.
        /// </summary>
        /// <param name="state">The State of the application. Possible values
        /// include: 'NEW', 'NEW_SAVING', 'SUBMITTED', 'ACCEPTED', 'RUNNING',
        /// 'FINISHED', 'FINISHING', 'FAILED', 'KILLED'</param>
        public AppState(ApplicationState? state = default(ApplicationState?))
        {
            State = state;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the State of the application. Possible values include:
        /// 'NEW', 'NEW_SAVING', 'SUBMITTED', 'ACCEPTED', 'RUNNING',
        /// 'FINISHED', 'FINISHING', 'FAILED', 'KILLED'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public ApplicationState? State { get; set; }

    }
}
