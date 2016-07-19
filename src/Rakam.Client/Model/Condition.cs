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
    /// Condition
    /// </summary>
    [DataContract]
    public partial class Condition :  IEquatable<Condition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Condition" /> class.
        /// </summary>
        /// <param name="Property">Property.</param>
        /// <param name="ExpectedValue">ExpectedValue.</param>
        public Condition(string Property = null, string ExpectedValue = null)
        {
            this.Property = Property;
            this.ExpectedValue = ExpectedValue;
        }
        
        /// <summary>
        /// Gets or Sets Property
        /// </summary>
        [DataMember(Name="property", EmitDefaultValue=false)]
        public string Property { get; set; }
        /// <summary>
        /// Gets or Sets ExpectedValue
        /// </summary>
        [DataMember(Name="expectedValue", EmitDefaultValue=false)]
        public string ExpectedValue { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Condition {\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
            sb.Append("  ExpectedValue: ").Append(ExpectedValue).Append("\n");
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
            return this.Equals(obj as Condition);
        }

        /// <summary>
        /// Returns true if Condition instances are equal
        /// </summary>
        /// <param name="other">Instance of Condition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Condition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Property == other.Property ||
                    this.Property != null &&
                    this.Property.Equals(other.Property)
                ) && 
                (
                    this.ExpectedValue == other.ExpectedValue ||
                    this.ExpectedValue != null &&
                    this.ExpectedValue.Equals(other.ExpectedValue)
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
                if (this.Property != null)
                    hash = hash * 59 + this.Property.GetHashCode();
                if (this.ExpectedValue != null)
                    hash = hash * 59 + this.ExpectedValue.GetHashCode();
                return hash;
            }
        }
    }

}
