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
    /// ProjectCheckApiKeys
    /// </summary>
    [DataContract]
    public partial class ProjectCheckApiKeys :  IEquatable<ProjectCheckApiKeys>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCheckApiKeys" /> class.
        /// </summary>
        /// <param name="Keys">Keys.</param>
        /// <param name="Project">Project.</param>
        public ProjectCheckApiKeys(List<ProjectApiKeys> Keys = null, string Project = null)
        {
            this.Keys = Keys;
            this.Project = Project;
        }
        
        /// <summary>
        /// Gets or Sets Keys
        /// </summary>
        [DataMember(Name="keys", EmitDefaultValue=false)]
        public List<ProjectApiKeys> Keys { get; set; }
        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="project", EmitDefaultValue=false)]
        public string Project { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectCheckApiKeys {\n");
            sb.Append("  Keys: ").Append(Keys).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
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
            return this.Equals(obj as ProjectCheckApiKeys);
        }

        /// <summary>
        /// Returns true if ProjectCheckApiKeys instances are equal
        /// </summary>
        /// <param name="other">Instance of ProjectCheckApiKeys to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectCheckApiKeys other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Keys == other.Keys ||
                    this.Keys != null &&
                    this.Keys.SequenceEqual(other.Keys)
                ) && 
                (
                    this.Project == other.Project ||
                    this.Project != null &&
                    this.Project.Equals(other.Project)
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
                if (this.Keys != null)
                    hash = hash * 59 + this.Keys.GetHashCode();
                if (this.Project != null)
                    hash = hash * 59 + this.Project.GetHashCode();
                return hash;
            }
        }
    }

}
