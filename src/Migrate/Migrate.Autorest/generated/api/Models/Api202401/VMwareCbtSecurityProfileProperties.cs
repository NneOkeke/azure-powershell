// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>VMwareCbt security profile input.</summary>
    public partial class VMwareCbtSecurityProfileProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtSecurityProfileProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtSecurityProfilePropertiesInternal
    {

        /// <summary>
        /// Backing field for <see cref="IsTargetVMConfidentialEncryptionEnabled" /> property.
        /// </summary>
        private string _isTargetVMConfidentialEncryptionEnabled;

        /// <summary>A value indicating whether confidential compute encryption to be enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string IsTargetVMConfidentialEncryptionEnabled { get => this._isTargetVMConfidentialEncryptionEnabled; set => this._isTargetVMConfidentialEncryptionEnabled = value; }

        /// <summary>Backing field for <see cref="IsTargetVMIntegrityMonitoringEnabled" /> property.</summary>
        private string _isTargetVMIntegrityMonitoringEnabled;

        /// <summary>A value indicating whether integrity monitoring to be enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string IsTargetVMIntegrityMonitoringEnabled { get => this._isTargetVMIntegrityMonitoringEnabled; set => this._isTargetVMIntegrityMonitoringEnabled = value; }

        /// <summary>Backing field for <see cref="IsTargetVMSecureBootEnabled" /> property.</summary>
        private string _isTargetVMSecureBootEnabled;

        /// <summary>A value indicating whether secure boot to be enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string IsTargetVMSecureBootEnabled { get => this._isTargetVMSecureBootEnabled; set => this._isTargetVMSecureBootEnabled = value; }

        /// <summary>Backing field for <see cref="IsTargetVMTpmEnabled" /> property.</summary>
        private string _isTargetVMTpmEnabled;

        /// <summary>A value indicating whether trusted platform module to be enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string IsTargetVMTpmEnabled { get => this._isTargetVMTpmEnabled; set => this._isTargetVMTpmEnabled = value; }

        /// <summary>Backing field for <see cref="TargetVMSecurityType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SecurityType? _targetVMSecurityType;

        /// <summary>The target VM security type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SecurityType? TargetVMSecurityType { get => this._targetVMSecurityType; set => this._targetVMSecurityType = value; }

        /// <summary>Creates an new <see cref="VMwareCbtSecurityProfileProperties" /> instance.</summary>
        public VMwareCbtSecurityProfileProperties()
        {

        }
    }
    /// VMwareCbt security profile input.
    public partial interface IVMwareCbtSecurityProfileProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>A value indicating whether confidential compute encryption to be enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether confidential compute encryption to be enabled.",
        SerializedName = @"isTargetVmConfidentialEncryptionEnabled",
        PossibleTypes = new [] { typeof(string) })]
        string IsTargetVMConfidentialEncryptionEnabled { get; set; }
        /// <summary>A value indicating whether integrity monitoring to be enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether integrity monitoring to be enabled.",
        SerializedName = @"isTargetVmIntegrityMonitoringEnabled",
        PossibleTypes = new [] { typeof(string) })]
        string IsTargetVMIntegrityMonitoringEnabled { get; set; }
        /// <summary>A value indicating whether secure boot to be enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether secure boot to be enabled.",
        SerializedName = @"isTargetVmSecureBootEnabled",
        PossibleTypes = new [] { typeof(string) })]
        string IsTargetVMSecureBootEnabled { get; set; }
        /// <summary>A value indicating whether trusted platform module to be enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether trusted platform module to be enabled.",
        SerializedName = @"isTargetVmTpmEnabled",
        PossibleTypes = new [] { typeof(string) })]
        string IsTargetVMTpmEnabled { get; set; }
        /// <summary>The target VM security type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target VM security type.",
        SerializedName = @"targetVmSecurityType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SecurityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SecurityType? TargetVMSecurityType { get; set; }

    }
    /// VMwareCbt security profile input.
    internal partial interface IVMwareCbtSecurityProfilePropertiesInternal

    {
        /// <summary>A value indicating whether confidential compute encryption to be enabled.</summary>
        string IsTargetVMConfidentialEncryptionEnabled { get; set; }
        /// <summary>A value indicating whether integrity monitoring to be enabled.</summary>
        string IsTargetVMIntegrityMonitoringEnabled { get; set; }
        /// <summary>A value indicating whether secure boot to be enabled.</summary>
        string IsTargetVMSecureBootEnabled { get; set; }
        /// <summary>A value indicating whether trusted platform module to be enabled.</summary>
        string IsTargetVMTpmEnabled { get; set; }
        /// <summary>The target VM security type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SecurityType? TargetVMSecurityType { get; set; }

    }
}