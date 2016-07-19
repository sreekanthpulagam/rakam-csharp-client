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
    /// ExportQuery
    /// </summary>
    [DataContract]
    public partial class ExportQuery :  IEquatable<ExportQuery>
    {
        /// <summary>
        /// Gets or Sets ExportType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExportTypeEnum
        {
            
            /// <summary>
            /// Enum AVRO for "AVRO"
            /// </summary>
            [EnumMember(Value = "AVRO")]
            AVRO,
            
            /// <summary>
            /// Enum CSV for "CSV"
            /// </summary>
            [EnumMember(Value = "CSV")]
            CSV,
            
            /// <summary>
            /// Enum JSON for "JSON"
            /// </summary>
            [EnumMember(Value = "JSON")]
            JSON
        }

        /// <summary>
        /// Gets or Sets ExportType
        /// </summary>
        [DataMember(Name="exportType", EmitDefaultValue=false)]
        public ExportTypeEnum? ExportType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportQuery" /> class.
        /// </summary>
        /// <param name="Query">SQL query that will be executed on data-set.</param>
        /// <param name="Limit">Limit.</param>
        /// <param name="ExportType">ExportType.</param>
        public ExportQuery(string Query = null, int? Limit = null, ExportTypeEnum? ExportType = null)
        {
            this.Query = Query;
            this.Limit = Limit;
            this.ExportType = ExportType;
        }
        
        /// <summary>
        /// SQL query that will be executed on data-set
        /// </summary>
        /// <value>SQL query that will be executed on data-set</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }
        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportQuery {\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  ExportType: ").Append(ExportType).Append("\n");
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
            return this.Equals(obj as ExportQuery);
        }

        /// <summary>
        /// Returns true if ExportQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of ExportQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExportQuery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Query == other.Query ||
                    this.Query != null &&
                    this.Query.Equals(other.Query)
                ) && 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
                ) && 
                (
                    this.ExportType == other.ExportType ||
                    this.ExportType != null &&
                    this.ExportType.Equals(other.ExportType)
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
                if (this.Query != null)
                    hash = hash * 59 + this.Query.GetHashCode();
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                if (this.ExportType != null)
                    hash = hash * 59 + this.ExportType.GetHashCode();
                return hash;
            }
        }
    }

}
