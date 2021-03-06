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
    /// Measure
    /// </summary>
    [DataContract]
    public partial class Measure :  IEquatable<Measure>
    {
        /// <summary>
        /// Gets or Sets Aggregation
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AggregationEnum
        {
            
            /// <summary>
            /// Enum COUNT for "COUNT"
            /// </summary>
            [EnumMember(Value = "COUNT")]
            COUNT,
            
            /// <summary>
            /// Enum COUNTUNIQUE for "COUNT_UNIQUE"
            /// </summary>
            [EnumMember(Value = "COUNT_UNIQUE")]
            COUNTUNIQUE,
            
            /// <summary>
            /// Enum SUM for "SUM"
            /// </summary>
            [EnumMember(Value = "SUM")]
            SUM,
            
            /// <summary>
            /// Enum MINIMUM for "MINIMUM"
            /// </summary>
            [EnumMember(Value = "MINIMUM")]
            MINIMUM,
            
            /// <summary>
            /// Enum MAXIMUM for "MAXIMUM"
            /// </summary>
            [EnumMember(Value = "MAXIMUM")]
            MAXIMUM,
            
            /// <summary>
            /// Enum AVERAGE for "AVERAGE"
            /// </summary>
            [EnumMember(Value = "AVERAGE")]
            AVERAGE,
            
            /// <summary>
            /// Enum APPROXIMATEUNIQUE for "APPROXIMATE_UNIQUE"
            /// </summary>
            [EnumMember(Value = "APPROXIMATE_UNIQUE")]
            APPROXIMATEUNIQUE
        }

        /// <summary>
        /// Gets or Sets Aggregation
        /// </summary>
        [DataMember(Name="aggregation", EmitDefaultValue=false)]
        public AggregationEnum? Aggregation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Measure" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Measure() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Measure" /> class.
        /// </summary>
        /// <param name="Column">Column (required).</param>
        /// <param name="Aggregation">Aggregation (required).</param>
        public Measure(string Column = null, AggregationEnum? Aggregation = null)
        {
            // to ensure "Column" is required (not null)
            if (Column == null)
            {
                throw new InvalidDataException("Column is a required property for Measure and cannot be null");
            }
            else
            {
                this.Column = Column;
            }
            // to ensure "Aggregation" is required (not null)
            if (Aggregation == null)
            {
                throw new InvalidDataException("Aggregation is a required property for Measure and cannot be null");
            }
            else
            {
                this.Aggregation = Aggregation;
            }
        }
        
        /// <summary>
        /// Gets or Sets Column
        /// </summary>
        [DataMember(Name="column", EmitDefaultValue=false)]
        public string Column { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Measure {\n");
            sb.Append("  Column: ").Append(Column).Append("\n");
            sb.Append("  Aggregation: ").Append(Aggregation).Append("\n");
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
            return this.Equals(obj as Measure);
        }

        /// <summary>
        /// Returns true if Measure instances are equal
        /// </summary>
        /// <param name="other">Instance of Measure to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Measure other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Column == other.Column ||
                    this.Column != null &&
                    this.Column.Equals(other.Column)
                ) && 
                (
                    this.Aggregation == other.Aggregation ||
                    this.Aggregation != null &&
                    this.Aggregation.Equals(other.Aggregation)
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
                if (this.Column != null)
                    hash = hash * 59 + this.Column.GetHashCode();
                if (this.Aggregation != null)
                    hash = hash * 59 + this.Aggregation.GetHashCode();
                return hash;
            }
        }
    }

}
