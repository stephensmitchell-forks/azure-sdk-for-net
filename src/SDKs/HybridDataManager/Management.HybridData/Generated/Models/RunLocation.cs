// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HybridData.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for RunLocation.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RunLocation
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "australiaeast")]
        Australiaeast,
        [EnumMember(Value = "australiasoutheast")]
        Australiasoutheast,
        [EnumMember(Value = "brazilsouth")]
        Brazilsouth,
        [EnumMember(Value = "canadacentral")]
        Canadacentral,
        [EnumMember(Value = "canadaeast")]
        Canadaeast,
        [EnumMember(Value = "centralindia")]
        Centralindia,
        [EnumMember(Value = "centralus")]
        Centralus,
        [EnumMember(Value = "eastasia")]
        Eastasia,
        [EnumMember(Value = "eastus")]
        Eastus,
        [EnumMember(Value = "eastus2")]
        Eastus2,
        [EnumMember(Value = "japaneast")]
        Japaneast,
        [EnumMember(Value = "japanwest")]
        Japanwest,
        [EnumMember(Value = "koreacentral")]
        Koreacentral,
        [EnumMember(Value = "koreasouth")]
        Koreasouth,
        [EnumMember(Value = "southeastasia")]
        Southeastasia,
        [EnumMember(Value = "southcentralus")]
        Southcentralus,
        [EnumMember(Value = "southindia")]
        Southindia,
        [EnumMember(Value = "northcentralus")]
        Northcentralus,
        [EnumMember(Value = "northeurope")]
        Northeurope,
        [EnumMember(Value = "uksouth")]
        Uksouth,
        [EnumMember(Value = "ukwest")]
        Ukwest,
        [EnumMember(Value = "westcentralus")]
        Westcentralus,
        [EnumMember(Value = "westeurope")]
        Westeurope,
        [EnumMember(Value = "westindia")]
        Westindia,
        [EnumMember(Value = "westus")]
        Westus,
        [EnumMember(Value = "westus2")]
        Westus2
    }
    internal static class RunLocationEnumExtension
    {
        internal static string ToSerializedValue(this RunLocation? value)
        {
            return value == null ? null : ((RunLocation)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this RunLocation value)
        {
            switch( value )
            {
                case RunLocation.None:
                    return "none";
                case RunLocation.Australiaeast:
                    return "australiaeast";
                case RunLocation.Australiasoutheast:
                    return "australiasoutheast";
                case RunLocation.Brazilsouth:
                    return "brazilsouth";
                case RunLocation.Canadacentral:
                    return "canadacentral";
                case RunLocation.Canadaeast:
                    return "canadaeast";
                case RunLocation.Centralindia:
                    return "centralindia";
                case RunLocation.Centralus:
                    return "centralus";
                case RunLocation.Eastasia:
                    return "eastasia";
                case RunLocation.Eastus:
                    return "eastus";
                case RunLocation.Eastus2:
                    return "eastus2";
                case RunLocation.Japaneast:
                    return "japaneast";
                case RunLocation.Japanwest:
                    return "japanwest";
                case RunLocation.Koreacentral:
                    return "koreacentral";
                case RunLocation.Koreasouth:
                    return "koreasouth";
                case RunLocation.Southeastasia:
                    return "southeastasia";
                case RunLocation.Southcentralus:
                    return "southcentralus";
                case RunLocation.Southindia:
                    return "southindia";
                case RunLocation.Northcentralus:
                    return "northcentralus";
                case RunLocation.Northeurope:
                    return "northeurope";
                case RunLocation.Uksouth:
                    return "uksouth";
                case RunLocation.Ukwest:
                    return "ukwest";
                case RunLocation.Westcentralus:
                    return "westcentralus";
                case RunLocation.Westeurope:
                    return "westeurope";
                case RunLocation.Westindia:
                    return "westindia";
                case RunLocation.Westus:
                    return "westus";
                case RunLocation.Westus2:
                    return "westus2";
            }
            return null;
        }

        internal static RunLocation? ParseRunLocation(this string value)
        {
            switch( value )
            {
                case "none":
                    return RunLocation.None;
                case "australiaeast":
                    return RunLocation.Australiaeast;
                case "australiasoutheast":
                    return RunLocation.Australiasoutheast;
                case "brazilsouth":
                    return RunLocation.Brazilsouth;
                case "canadacentral":
                    return RunLocation.Canadacentral;
                case "canadaeast":
                    return RunLocation.Canadaeast;
                case "centralindia":
                    return RunLocation.Centralindia;
                case "centralus":
                    return RunLocation.Centralus;
                case "eastasia":
                    return RunLocation.Eastasia;
                case "eastus":
                    return RunLocation.Eastus;
                case "eastus2":
                    return RunLocation.Eastus2;
                case "japaneast":
                    return RunLocation.Japaneast;
                case "japanwest":
                    return RunLocation.Japanwest;
                case "koreacentral":
                    return RunLocation.Koreacentral;
                case "koreasouth":
                    return RunLocation.Koreasouth;
                case "southeastasia":
                    return RunLocation.Southeastasia;
                case "southcentralus":
                    return RunLocation.Southcentralus;
                case "southindia":
                    return RunLocation.Southindia;
                case "northcentralus":
                    return RunLocation.Northcentralus;
                case "northeurope":
                    return RunLocation.Northeurope;
                case "uksouth":
                    return RunLocation.Uksouth;
                case "ukwest":
                    return RunLocation.Ukwest;
                case "westcentralus":
                    return RunLocation.Westcentralus;
                case "westeurope":
                    return RunLocation.Westeurope;
                case "westindia":
                    return RunLocation.Westindia;
                case "westus":
                    return RunLocation.Westus;
                case "westus2":
                    return RunLocation.Westus2;
            }
            return null;
        }
    }
}
