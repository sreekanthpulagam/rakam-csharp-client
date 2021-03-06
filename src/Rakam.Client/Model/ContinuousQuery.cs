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
    /// ContinuousQuery
    /// </summary>
    [DataContract]
    public partial class ContinuousQuery :  IEquatable<ContinuousQuery>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContinuousQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContinuousQuery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContinuousQuery" /> class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        /// <param name="Query">Query (required).</param>
        /// <param name="Options">Options.</param>
        /// <param name="TableName">TableName.</param>
        /// <param name="PartitionKeys">PartitionKeys.</param>
        public ContinuousQuery(string Name = null, string Query = null, Dictionary<string, Object> Options = null, string TableName = null, List<string> PartitionKeys = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ContinuousQuery and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Query" is required (not null)
            if (Query == null)
            {
                throw new InvalidDataException("Query is a required property for ContinuousQuery and cannot be null");
            }
            else
            {
                this.Query = Query;
            }
            this.Options = Options;
            this.TableName = TableName;
            this.PartitionKeys = PartitionKeys;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }
        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public Dictionary<string, Object> Options { get; set; }
        /// <summary>
        /// Gets or Sets TableName
        /// </summary>
        [DataMember(Name="tableName", EmitDefaultValue=false)]
        public string TableName { get; set; }
        /// <summary>
        /// Gets or Sets PartitionKeys
        /// </summary>
        [DataMember(Name="partitionKeys", EmitDefaultValue=false)]
        public List<string> PartitionKeys { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContinuousQuery {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
            sb.Append("  PartitionKeys: ").Append(PartitionKeys).Append("\n");
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
            return this.Equals(obj as ContinuousQuery);
        }

        /// <summary>
        /// Returns true if ContinuousQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of ContinuousQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContinuousQuery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Query == other.Query ||
                    this.Query != null &&
                    this.Query.Equals(other.Query)
                ) && 
                (
                    this.Options == other.Options ||
                    this.Options != null &&
                    this.Options.SequenceEqual(other.Options)
                ) && 
                (
                    this.TableName == other.TableName ||
                    this.TableName != null &&
                    this.TableName.Equals(other.TableName)
                ) && 
                (
                    this.PartitionKeys == other.PartitionKeys ||
                    this.PartitionKeys != null &&
                    this.PartitionKeys.SequenceEqual(other.PartitionKeys)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Query != null)
                    hash = hash * 59 + this.Query.GetHashCode();
                if (this.Options != null)
                    hash = hash * 59 + this.Options.GetHashCode();
                if (this.TableName != null)
                    hash = hash * 59 + this.TableName.GetHashCode();
                if (this.PartitionKeys != null)
                    hash = hash * 59 + this.PartitionKeys.GetHashCode();
                return hash;
            }
        }
    }

}
