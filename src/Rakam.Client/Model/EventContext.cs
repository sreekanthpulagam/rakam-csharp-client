/* 
 * Rakam API Documentation
 *
 * An analytics platform API that lets you create your own analytics services.
 *
 * OpenAPI spec version: 0.5
 * Contact: contact@rakam.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Rakam.Client.Model
{
    /// <summary>
    /// EventContext
    /// </summary>
    [DataContract]
    public partial class EventContext :  IEquatable<EventContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventContext" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EventContext() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EventContext" /> class.
        /// </summary>
        /// <param name="ApiKey">ApiKey (required).</param>
        /// <param name="Library">Library (required).</param>
        /// <param name="ApiVersion">ApiVersion (required).</param>
        /// <param name="UploadTime">UploadTime (required).</param>
        /// <param name="Checksum">Checksum (required).</param>
        /// <param name="Plugins">Plugins (required).</param>
        public EventContext(string ApiKey = null, Library Library = null, string ApiVersion = null, long? UploadTime = null, string Checksum = null, List<MappingPlugin> Plugins = null)
        {
            // to ensure "ApiKey" is required (not null)
            if (ApiKey == null)
            {
                throw new InvalidDataException("ApiKey is a required property for EventContext and cannot be null");
            }
            else
            {
                this.ApiKey = ApiKey;
            }
            // to ensure "Library" is required (not null)
            if (Library == null)
            {
                throw new InvalidDataException("Library is a required property for EventContext and cannot be null");
            }
            else
            {
                this.Library = Library;
            }
            // to ensure "ApiVersion" is required (not null)
            if (ApiVersion == null)
            {
                throw new InvalidDataException("ApiVersion is a required property for EventContext and cannot be null");
            }
            else
            {
                this.ApiVersion = ApiVersion;
            }
            // to ensure "UploadTime" is required (not null)
            if (UploadTime == null)
            {
                throw new InvalidDataException("UploadTime is a required property for EventContext and cannot be null");
            }
            else
            {
                this.UploadTime = UploadTime;
            }
            // to ensure "Checksum" is required (not null)
            if (Checksum == null)
            {
                throw new InvalidDataException("Checksum is a required property for EventContext and cannot be null");
            }
            else
            {
                this.Checksum = Checksum;
            }
            // to ensure "Plugins" is required (not null)
            if (Plugins == null)
            {
                throw new InvalidDataException("Plugins is a required property for EventContext and cannot be null");
            }
            else
            {
                this.Plugins = Plugins;
            }
        }
        
        /// <summary>
        /// Gets or Sets ApiKey
        /// </summary>
        [DataMember(Name="api_key", EmitDefaultValue=false)]
        public string ApiKey { get; set; }
        /// <summary>
        /// Gets or Sets Library
        /// </summary>
        [DataMember(Name="library", EmitDefaultValue=false)]
        public Library Library { get; set; }
        /// <summary>
        /// Gets or Sets ApiVersion
        /// </summary>
        [DataMember(Name="api_version", EmitDefaultValue=false)]
        public string ApiVersion { get; set; }
        /// <summary>
        /// Gets or Sets UploadTime
        /// </summary>
        [DataMember(Name="upload_time", EmitDefaultValue=false)]
        public long? UploadTime { get; set; }
        /// <summary>
        /// Gets or Sets Checksum
        /// </summary>
        [DataMember(Name="checksum", EmitDefaultValue=false)]
        public string Checksum { get; set; }
        /// <summary>
        /// Gets or Sets Plugins
        /// </summary>
        [DataMember(Name="plugins", EmitDefaultValue=false)]
        public List<MappingPlugin> Plugins { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventContext {\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  Library: ").Append(Library).Append("\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  UploadTime: ").Append(UploadTime).Append("\n");
            sb.Append("  Checksum: ").Append(Checksum).Append("\n");
            sb.Append("  Plugins: ").Append(Plugins).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as EventContext);
        }

        /// <summary>
        /// Returns true if EventContext instances are equal
        /// </summary>
        /// <param name="other">Instance of EventContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventContext other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApiKey == other.ApiKey ||
                    this.ApiKey != null &&
                    this.ApiKey.Equals(other.ApiKey)
                ) && 
                (
                    this.Library == other.Library ||
                    this.Library != null &&
                    this.Library.Equals(other.Library)
                ) && 
                (
                    this.ApiVersion == other.ApiVersion ||
                    this.ApiVersion != null &&
                    this.ApiVersion.Equals(other.ApiVersion)
                ) && 
                (
                    this.UploadTime == other.UploadTime ||
                    this.UploadTime != null &&
                    this.UploadTime.Equals(other.UploadTime)
                ) && 
                (
                    this.Checksum == other.Checksum ||
                    this.Checksum != null &&
                    this.Checksum.Equals(other.Checksum)
                ) && 
                (
                    this.Plugins == other.Plugins ||
                    this.Plugins != null &&
                    this.Plugins.SequenceEqual(other.Plugins)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ApiKey != null)
                    hash = hash * 59 + this.ApiKey.GetHashCode();
                if (this.Library != null)
                    hash = hash * 59 + this.Library.GetHashCode();
                if (this.ApiVersion != null)
                    hash = hash * 59 + this.ApiVersion.GetHashCode();
                if (this.UploadTime != null)
                    hash = hash * 59 + this.UploadTime.GetHashCode();
                if (this.Checksum != null)
                    hash = hash * 59 + this.Checksum.GetHashCode();
                if (this.Plugins != null)
                    hash = hash * 59 + this.Plugins.GetHashCode();
                return hash;
            }
        }
    }

}