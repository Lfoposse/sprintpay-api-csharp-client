/* 
 * Sprint-pay payment for developper
 *
 * This is a sample doc to use our sprint-pay payment api.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: sprint-pay@sprint-pay.com
 * Generated by: https://github.com/SprintPay-api/SprintPay-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SprintPayDateConverter = IO.SprintPay.Client.SprintPayDateConverter;

namespace IO.SprintPay.Model
{
    /// <summary>
    /// Orangemoney
    /// </summary>
    [DataContract]
    public partial class Orangemoney :  IEquatable<Orangemoney>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Orangemoney" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Orangemoney() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Orangemoney" /> class.
        /// </summary>
        /// <param name="Phone">Phone (required).</param>
        /// <param name="Amount">Amount (required).</param>
        public Orangemoney(long? Phone = default(long?), string Amount = default(string))
        {
            // to ensure "Phone" is required (not null)
            if (Phone == null)
            {
                throw new InvalidDataException("Phone is a required property for Orangemoney and cannot be null");
            }
            else
            {
                this.Phone = Phone;
            }
            // to ensure "Amount" is required (not null)
            if (Amount == null)
            {
                throw new InvalidDataException("Amount is a required property for Orangemoney and cannot be null");
            }
            else
            {
                this.Amount = Amount;
            }
        }
        
        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public long? Phone { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Orangemoney {\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Orangemoney);
        }

        /// <summary>
        /// Returns true if Orangemoney instances are equal
        /// </summary>
        /// <param name="input">Instance of Orangemoney to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Orangemoney input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
