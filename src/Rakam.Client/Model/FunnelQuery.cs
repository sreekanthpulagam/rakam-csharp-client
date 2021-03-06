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
    /// FunnelQuery
    /// </summary>
    [DataContract]
    public partial class FunnelQuery :  IEquatable<FunnelQuery>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FunnelQuery" /> class.
        /// </summary>
        /// <param name="Steps">Steps.</param>
        /// <param name="Dimension">Dimension.</param>
        /// <param name="StartDate">StartDate.</param>
        /// <param name="Window">Window.</param>
        /// <param name="EndDate">EndDate.</param>
        public FunnelQuery(List<FunnelStep> Steps = null, string Dimension = null, DateTime? StartDate = null, FunnelWindow Window = null, DateTime? EndDate = null)
        {
            this.Steps = Steps;
            this.Dimension = Dimension;
            this.StartDate = StartDate;
            this.Window = Window;
            this.EndDate = EndDate;
        }
        
        /// <summary>
        /// Gets or Sets Steps
        /// </summary>
        [DataMember(Name="steps", EmitDefaultValue=false)]
        public List<FunnelStep> Steps { get; set; }
        /// <summary>
        /// Gets or Sets Dimension
        /// </summary>
        [DataMember(Name="dimension", EmitDefaultValue=false)]
        public string Dimension { get; set; }
        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// Gets or Sets Window
        /// </summary>
        [DataMember(Name="window", EmitDefaultValue=false)]
        public FunnelWindow Window { get; set; }
        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FunnelQuery {\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("  Dimension: ").Append(Dimension).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Window: ").Append(Window).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
            return this.Equals(obj as FunnelQuery);
        }

        /// <summary>
        /// Returns true if FunnelQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of FunnelQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FunnelQuery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Steps == other.Steps ||
                    this.Steps != null &&
                    this.Steps.SequenceEqual(other.Steps)
                ) && 
                (
                    this.Dimension == other.Dimension ||
                    this.Dimension != null &&
                    this.Dimension.Equals(other.Dimension)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) && 
                (
                    this.Window == other.Window ||
                    this.Window != null &&
                    this.Window.Equals(other.Window)
                ) && 
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
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
                if (this.Steps != null)
                    hash = hash * 59 + this.Steps.GetHashCode();
                if (this.Dimension != null)
                    hash = hash * 59 + this.Dimension.GetHashCode();
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                if (this.Window != null)
                    hash = hash * 59 + this.Window.GetHashCode();
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                return hash;
            }
        }
    }

}
