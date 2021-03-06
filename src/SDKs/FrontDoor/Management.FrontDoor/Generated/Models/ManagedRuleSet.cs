// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines a managed rule set.
    /// </summary>
    public partial class ManagedRuleSet
    {
        /// <summary>
        /// Initializes a new instance of the ManagedRuleSet class.
        /// </summary>
        public ManagedRuleSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedRuleSet class.
        /// </summary>
        /// <param name="ruleSetType">Defines the rule set type to use.</param>
        /// <param name="ruleSetVersion">Defines the version of the rule set to
        /// use.</param>
        /// <param name="ruleGroupOverrides">Defines the rule group overrides
        /// to apply to the rule set.</param>
        public ManagedRuleSet(string ruleSetType, string ruleSetVersion, IList<ManagedRuleGroupOverride> ruleGroupOverrides = default(IList<ManagedRuleGroupOverride>))
        {
            RuleSetType = ruleSetType;
            RuleSetVersion = ruleSetVersion;
            RuleGroupOverrides = ruleGroupOverrides;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets defines the rule set type to use.
        /// </summary>
        [JsonProperty(PropertyName = "ruleSetType")]
        public string RuleSetType { get; set; }

        /// <summary>
        /// Gets or sets defines the version of the rule set to use.
        /// </summary>
        [JsonProperty(PropertyName = "ruleSetVersion")]
        public string RuleSetVersion { get; set; }

        /// <summary>
        /// Gets or sets defines the rule group overrides to apply to the rule
        /// set.
        /// </summary>
        [JsonProperty(PropertyName = "ruleGroupOverrides")]
        public IList<ManagedRuleGroupOverride> RuleGroupOverrides { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RuleSetType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RuleSetType");
            }
            if (RuleSetVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RuleSetVersion");
            }
            if (RuleGroupOverrides != null)
            {
                foreach (var element in RuleGroupOverrides)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
