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
    /// ResponseQuery
    /// </summary>
    [DataContract]
    public partial class ResponseQuery :  IEquatable<ResponseQuery>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseQuery" /> class.
        /// </summary>
        /// <param name="GroupBy">GroupBy.</param>
        /// <param name="OrderBy">OrderBy.</param>
        /// <param name="Limit">Limit.</param>
        public ResponseQuery(List<GroupBy> GroupBy = null, List<Ordering> OrderBy = null, long? Limit = null)
        {
            this.GroupBy = GroupBy;
            this.OrderBy = OrderBy;
            this.Limit = Limit;
        }
        
        /// <summary>
        /// Gets or Sets GroupBy
        /// </summary>
        [DataMember(Name="groupBy", EmitDefaultValue=false)]
        public List<GroupBy> GroupBy { get; set; }
        /// <summary>
        /// Gets or Sets OrderBy
        /// </summary>
        [DataMember(Name="orderBy", EmitDefaultValue=false)]
        public List<Ordering> OrderBy { get; set; }
        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public long? Limit { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseQuery {\n");
            sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
            sb.Append("  OrderBy: ").Append(OrderBy).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
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
            return this.Equals(obj as ResponseQuery);
        }

        /// <summary>
        /// Returns true if ResponseQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of ResponseQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseQuery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.GroupBy == other.GroupBy ||
                    this.GroupBy != null &&
                    this.GroupBy.SequenceEqual(other.GroupBy)
                ) && 
                (
                    this.OrderBy == other.OrderBy ||
                    this.OrderBy != null &&
                    this.OrderBy.SequenceEqual(other.OrderBy)
                ) && 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
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
                if (this.GroupBy != null)
                    hash = hash * 59 + this.GroupBy.GetHashCode();
                if (this.OrderBy != null)
                    hash = hash * 59 + this.OrderBy.GetHashCode();
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                return hash;
            }
        }
    }

}
