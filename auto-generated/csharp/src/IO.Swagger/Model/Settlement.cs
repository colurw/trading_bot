/* 
 * BitMEX API
 *
 * ## REST API for the BitMEX Trading Platform  _If you are building automated tools, please subscribe to the_ _[BitMEX API RSS Feed](https://blog.bitmex.com/api_announcement/feed/) for changes. The feed will be updated_ _regularly and is the most reliable way to get downtime and update announcements._  [View Changelog](/app/apiChangelog)  -  #### Getting Started  Base URI: [https://www.bitmex.com/api/v1](/api/v1)  ##### Fetching Data  All REST endpoints are documented below. You can try out any query right from this interface.  Most table queries accept `count`, `start`, and `reverse` params. Set `reverse=true` to get rows newest-first.  Additional documentation regarding filters, timestamps, and authentication is available in [the main API documentation](/app/restAPI).  _All_ table data is available via the [Websocket](/app/wsAPI). We highly recommend using the socket if you want to have the quickest possible data without being subject to ratelimits.  ##### Return Types  By default, all data is returned as JSON. Send `?_format=csv` to get CSV data or `?_format=xml` to get XML data.  ##### Trade Data Queries  _This is only a small subset of what is available, to get you started._  Fill in the parameters and click the `Try it out!` button to try any of these queries.  - [Pricing Data](#!/Quote/Quote_get)  - [Trade Data](#!/Trade/Trade_get)  - [OrderBook Data](#!/OrderBook/OrderBook_getL2)  - [Settlement Data](#!/Settlement/Settlement_get)  - [Exchange Statistics](#!/Stats/Stats_history)  Every function of the BitMEX.com platform is exposed here and documented. Many more functions are available.  ##### Swagger Specification  [⇩ Download Swagger JSON](swagger.json)  -  ## All API Endpoints  Click to expand a section. 
 *
 * OpenAPI spec version: 1.2.0
 * Contact: support@bitmex.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Historical Settlement Data
    /// </summary>
    [DataContract]
    public partial class Settlement :  IEquatable<Settlement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Settlement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Settlement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Settlement" /> class.
        /// </summary>
        /// <param name="timestamp">timestamp (required).</param>
        /// <param name="symbol">symbol (required).</param>
        /// <param name="settlementType">settlementType.</param>
        /// <param name="settledPrice">settledPrice.</param>
        /// <param name="optionStrikePrice">optionStrikePrice.</param>
        /// <param name="optionUnderlyingPrice">optionUnderlyingPrice.</param>
        /// <param name="bankrupt">bankrupt.</param>
        /// <param name="taxBase">taxBase.</param>
        /// <param name="taxRate">taxRate.</param>
        public Settlement(DateTime? timestamp = default(DateTime?), string symbol = default(string), string settlementType = default(string), double? settledPrice = default(double?), double? optionStrikePrice = default(double?), double? optionUnderlyingPrice = default(double?), long? bankrupt = default(long?), long? taxBase = default(long?), double? taxRate = default(double?))
        {
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new InvalidDataException("timestamp is a required property for Settlement and cannot be null");
            }
            else
            {
                this.Timestamp = timestamp;
            }
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new InvalidDataException("symbol is a required property for Settlement and cannot be null");
            }
            else
            {
                this.Symbol = symbol;
            }
            this.SettlementType = settlementType;
            this.SettledPrice = settledPrice;
            this.OptionStrikePrice = optionStrikePrice;
            this.OptionUnderlyingPrice = optionUnderlyingPrice;
            this.Bankrupt = bankrupt;
            this.TaxBase = taxBase;
            this.TaxRate = taxRate;
        }
        
        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets SettlementType
        /// </summary>
        [DataMember(Name="settlementType", EmitDefaultValue=false)]
        public string SettlementType { get; set; }

        /// <summary>
        /// Gets or Sets SettledPrice
        /// </summary>
        [DataMember(Name="settledPrice", EmitDefaultValue=false)]
        public double? SettledPrice { get; set; }

        /// <summary>
        /// Gets or Sets OptionStrikePrice
        /// </summary>
        [DataMember(Name="optionStrikePrice", EmitDefaultValue=false)]
        public double? OptionStrikePrice { get; set; }

        /// <summary>
        /// Gets or Sets OptionUnderlyingPrice
        /// </summary>
        [DataMember(Name="optionUnderlyingPrice", EmitDefaultValue=false)]
        public double? OptionUnderlyingPrice { get; set; }

        /// <summary>
        /// Gets or Sets Bankrupt
        /// </summary>
        [DataMember(Name="bankrupt", EmitDefaultValue=false)]
        public long? Bankrupt { get; set; }

        /// <summary>
        /// Gets or Sets TaxBase
        /// </summary>
        [DataMember(Name="taxBase", EmitDefaultValue=false)]
        public long? TaxBase { get; set; }

        /// <summary>
        /// Gets or Sets TaxRate
        /// </summary>
        [DataMember(Name="taxRate", EmitDefaultValue=false)]
        public double? TaxRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Settlement {\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  SettlementType: ").Append(SettlementType).Append("\n");
            sb.Append("  SettledPrice: ").Append(SettledPrice).Append("\n");
            sb.Append("  OptionStrikePrice: ").Append(OptionStrikePrice).Append("\n");
            sb.Append("  OptionUnderlyingPrice: ").Append(OptionUnderlyingPrice).Append("\n");
            sb.Append("  Bankrupt: ").Append(Bankrupt).Append("\n");
            sb.Append("  TaxBase: ").Append(TaxBase).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as Settlement);
        }

        /// <summary>
        /// Returns true if Settlement instances are equal
        /// </summary>
        /// <param name="input">Instance of Settlement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Settlement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.SettlementType == input.SettlementType ||
                    (this.SettlementType != null &&
                    this.SettlementType.Equals(input.SettlementType))
                ) && 
                (
                    this.SettledPrice == input.SettledPrice ||
                    (this.SettledPrice != null &&
                    this.SettledPrice.Equals(input.SettledPrice))
                ) && 
                (
                    this.OptionStrikePrice == input.OptionStrikePrice ||
                    (this.OptionStrikePrice != null &&
                    this.OptionStrikePrice.Equals(input.OptionStrikePrice))
                ) && 
                (
                    this.OptionUnderlyingPrice == input.OptionUnderlyingPrice ||
                    (this.OptionUnderlyingPrice != null &&
                    this.OptionUnderlyingPrice.Equals(input.OptionUnderlyingPrice))
                ) && 
                (
                    this.Bankrupt == input.Bankrupt ||
                    (this.Bankrupt != null &&
                    this.Bankrupt.Equals(input.Bankrupt))
                ) && 
                (
                    this.TaxBase == input.TaxBase ||
                    (this.TaxBase != null &&
                    this.TaxBase.Equals(input.TaxBase))
                ) && 
                (
                    this.TaxRate == input.TaxRate ||
                    (this.TaxRate != null &&
                    this.TaxRate.Equals(input.TaxRate))
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
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.SettlementType != null)
                    hashCode = hashCode * 59 + this.SettlementType.GetHashCode();
                if (this.SettledPrice != null)
                    hashCode = hashCode * 59 + this.SettledPrice.GetHashCode();
                if (this.OptionStrikePrice != null)
                    hashCode = hashCode * 59 + this.OptionStrikePrice.GetHashCode();
                if (this.OptionUnderlyingPrice != null)
                    hashCode = hashCode * 59 + this.OptionUnderlyingPrice.GetHashCode();
                if (this.Bankrupt != null)
                    hashCode = hashCode * 59 + this.Bankrupt.GetHashCode();
                if (this.TaxBase != null)
                    hashCode = hashCode * 59 + this.TaxBase.GetHashCode();
                if (this.TaxRate != null)
                    hashCode = hashCode * 59 + this.TaxRate.GetHashCode();
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
