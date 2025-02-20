// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Extensions;

    /// <summary>
    /// Configuration properties that define the mutable settings of a Container App SourceControl
    /// </summary>
    public partial class GithubActionConfiguration
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.App.Models.IGithubActionConfiguration.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.App.Models.IGithubActionConfiguration.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.IGithubActionConfiguration FromJson(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject json ? new GithubActionConfiguration(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject into a new instance of <see cref="GithubActionConfiguration" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal GithubActionConfiguration(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_registryInfo = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject>("registryInfo"), out var __jsonRegistryInfo) ? Microsoft.Azure.PowerShell.Cmdlets.App.Models.RegistryInfo.FromJson(__jsonRegistryInfo) : _registryInfo;}
            {_azureCredentials = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject>("azureCredentials"), out var __jsonAzureCredentials) ? Microsoft.Azure.PowerShell.Cmdlets.App.Models.AzureCredentials.FromJson(__jsonAzureCredentials) : _azureCredentials;}
            {_contextPath = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonString>("contextPath"), out var __jsonContextPath) ? (string)__jsonContextPath : (string)_contextPath;}
            {_image = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonString>("image"), out var __jsonImage) ? (string)__jsonImage : (string)_image;}
            {_publishType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonString>("publishType"), out var __jsonPublishType) ? (string)__jsonPublishType : (string)_publishType;}
            {_oS = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonString>("os"), out var __jsonOS) ? (string)__jsonOS : (string)_oS;}
            {_runtimeStack = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonString>("runtimeStack"), out var __jsonRuntimeStack) ? (string)__jsonRuntimeStack : (string)_runtimeStack;}
            {_runtimeVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonString>("runtimeVersion"), out var __jsonRuntimeVersion) ? (string)__jsonRuntimeVersion : (string)_runtimeVersion;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="GithubActionConfiguration" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="GithubActionConfiguration" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._registryInfo ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode) this._registryInfo.ToJson(null,serializationMode) : null, "registryInfo" ,container.Add );
            AddIf( null != this._azureCredentials ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode) this._azureCredentials.ToJson(null,serializationMode) : null, "azureCredentials" ,container.Add );
            AddIf( null != (((object)this._contextPath)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonString(this._contextPath.ToString()) : null, "contextPath" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.SerializationMode.IncludeUpdate)||serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.SerializationMode.IncludeCreate))
            {
                AddIf( null != (((object)this._githubPersonalAccessToken)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonString(System.Runtime.InteropServices.Marshal.PtrToStringBSTR(System.Runtime.InteropServices.Marshal.SecureStringToBSTR(this._githubPersonalAccessToken))) : null, "githubPersonalAccessToken" ,container.Add );
            }
            AddIf( null != (((object)this._image)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonString(this._image.ToString()) : null, "image" ,container.Add );
            AddIf( null != (((object)this._publishType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonString(this._publishType.ToString()) : null, "publishType" ,container.Add );
            AddIf( null != (((object)this._oS)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonString(this._oS.ToString()) : null, "os" ,container.Add );
            AddIf( null != (((object)this._runtimeStack)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonString(this._runtimeStack.ToString()) : null, "runtimeStack" ,container.Add );
            AddIf( null != (((object)this._runtimeVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonString(this._runtimeVersion.ToString()) : null, "runtimeVersion" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}