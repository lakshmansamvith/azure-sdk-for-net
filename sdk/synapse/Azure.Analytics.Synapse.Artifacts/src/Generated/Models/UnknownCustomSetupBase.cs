// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The UnknownCustomSetupBase. </summary>
    internal partial class UnknownCustomSetupBase : CustomSetupBase
    {
        /// <summary> Initializes a new instance of UnknownCustomSetupBase. </summary>
        /// <param name="type"> The type of custom setup. </param>
        internal UnknownCustomSetupBase(string type) : base(type)
        {
            Type = type ?? "Unknown";
        }
    }
}
