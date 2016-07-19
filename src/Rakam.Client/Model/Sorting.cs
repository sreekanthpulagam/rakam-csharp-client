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
    /// Sorting
    /// </summary>
    [DataContract]
    public partial class Sorting :  IEquatable<Sorting>
    {
        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrderEnum
        {
            
            /// <summary>
            /// Enum Asc for "asc"
            /// </summary>
            [EnumMember(Value = "asc")]
            Asc,
            
            /// <summary>
            /// Enum Desc for "desc"
            /// </summary>
            [EnumMember(Value = "desc")]
            Desc
        }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public OrderEnum? Order { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Sorting" /> class.
        /// </summary>
        /// <param name="Column">Column.</param>
        /// <param name="Order">Order.</param>
        public Sorting(string Column = null, OrderEnum? Order = null)
        {
            this.Column = Column;
            this.Order = Order;
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
            sb.Append("class Sorting {\n");
            sb.Append("  Column: ").Append(Column).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            return this.Equals(obj as Sorting);
        }

        /// <summary>
        /// Returns true if Sorting instances are equal
        /// </summary>
        /// <param name="other">Instance of Sorting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Sorting other)
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
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
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
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                return hash;
            }
        }
    }

}
