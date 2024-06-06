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
    /// Margin
    /// </summary>
    [DataContract]
    public partial class Margin :  IEquatable<Margin>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Margin" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Margin() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Margin" /> class.
        /// </summary>
        /// <param name="account">account (required) (default to 0).</param>
        /// <param name="currency">currency (required).</param>
        /// <param name="riskLimit">riskLimit (default to 0).</param>
        /// <param name="state">state.</param>
        /// <param name="amount">amount (default to 0).</param>
        /// <param name="prevRealisedPnl">prevRealisedPnl (default to 0).</param>
        /// <param name="grossComm">grossComm (default to 0).</param>
        /// <param name="grossOpenCost">grossOpenCost (default to 0).</param>
        /// <param name="grossOpenPremium">grossOpenPremium (default to 0).</param>
        /// <param name="grossExecCost">grossExecCost (default to 0).</param>
        /// <param name="grossMarkValue">grossMarkValue (default to 0).</param>
        /// <param name="riskValue">riskValue (default to 0).</param>
        /// <param name="initMargin">initMargin (default to 0).</param>
        /// <param name="maintMargin">maintMargin (default to 0).</param>
        /// <param name="targetExcessMargin">targetExcessMargin (default to 0).</param>
        /// <param name="realisedPnl">realisedPnl (default to 0).</param>
        /// <param name="unrealisedPnl">unrealisedPnl (default to 0).</param>
        /// <param name="walletBalance">walletBalance (default to 0).</param>
        /// <param name="marginBalance">marginBalance (default to 0).</param>
        /// <param name="marginLeverage">marginLeverage (default to 0.0).</param>
        /// <param name="marginUsedPcnt">marginUsedPcnt (default to 0.0).</param>
        /// <param name="excessMargin">excessMargin (default to 0).</param>
        /// <param name="availableMargin">availableMargin (default to 0).</param>
        /// <param name="withdrawableMargin">withdrawableMargin (default to 0).</param>
        /// <param name="makerFeeDiscount">makerFeeDiscount (default to 0.0).</param>
        /// <param name="takerFeeDiscount">takerFeeDiscount (default to 0.0).</param>
        /// <param name="timestamp">timestamp.</param>
        public Margin(long? account = 0, string currency = default(string), long? riskLimit = 0, string state = default(string), long? amount = 0, long? prevRealisedPnl = 0, long? grossComm = 0, long? grossOpenCost = 0, long? grossOpenPremium = 0, long? grossExecCost = 0, long? grossMarkValue = 0, long? riskValue = 0, long? initMargin = 0, long? maintMargin = 0, long? targetExcessMargin = 0, long? realisedPnl = 0, long? unrealisedPnl = 0, long? walletBalance = 0, long? marginBalance = 0, double? marginLeverage = 0.0, double? marginUsedPcnt = 0.0, long? excessMargin = 0, long? availableMargin = 0, long? withdrawableMargin = 0, double? makerFeeDiscount = 0.0, double? takerFeeDiscount = 0.0, DateTime? timestamp = default(DateTime?))
        {
            // to ensure "account" is required (not null)
            if (account == null)
            {
                throw new InvalidDataException("account is a required property for Margin and cannot be null");
            }
            else
            {
                this.Account = account;
            }
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new InvalidDataException("currency is a required property for Margin and cannot be null");
            }
            else
            {
                this.Currency = currency;
            }
            // use default value if no "riskLimit" provided
            if (riskLimit == null)
            {
                this.RiskLimit = 0;
            }
            else
            {
                this.RiskLimit = riskLimit;
            }
            this.State = state;
            // use default value if no "amount" provided
            if (amount == null)
            {
                this.Amount = 0;
            }
            else
            {
                this.Amount = amount;
            }
            // use default value if no "prevRealisedPnl" provided
            if (prevRealisedPnl == null)
            {
                this.PrevRealisedPnl = 0;
            }
            else
            {
                this.PrevRealisedPnl = prevRealisedPnl;
            }
            // use default value if no "grossComm" provided
            if (grossComm == null)
            {
                this.GrossComm = 0;
            }
            else
            {
                this.GrossComm = grossComm;
            }
            // use default value if no "grossOpenCost" provided
            if (grossOpenCost == null)
            {
                this.GrossOpenCost = 0;
            }
            else
            {
                this.GrossOpenCost = grossOpenCost;
            }
            // use default value if no "grossOpenPremium" provided
            if (grossOpenPremium == null)
            {
                this.GrossOpenPremium = 0;
            }
            else
            {
                this.GrossOpenPremium = grossOpenPremium;
            }
            // use default value if no "grossExecCost" provided
            if (grossExecCost == null)
            {
                this.GrossExecCost = 0;
            }
            else
            {
                this.GrossExecCost = grossExecCost;
            }
            // use default value if no "grossMarkValue" provided
            if (grossMarkValue == null)
            {
                this.GrossMarkValue = 0;
            }
            else
            {
                this.GrossMarkValue = grossMarkValue;
            }
            // use default value if no "riskValue" provided
            if (riskValue == null)
            {
                this.RiskValue = 0;
            }
            else
            {
                this.RiskValue = riskValue;
            }
            // use default value if no "initMargin" provided
            if (initMargin == null)
            {
                this.InitMargin = 0;
            }
            else
            {
                this.InitMargin = initMargin;
            }
            // use default value if no "maintMargin" provided
            if (maintMargin == null)
            {
                this.MaintMargin = 0;
            }
            else
            {
                this.MaintMargin = maintMargin;
            }
            // use default value if no "targetExcessMargin" provided
            if (targetExcessMargin == null)
            {
                this.TargetExcessMargin = 0;
            }
            else
            {
                this.TargetExcessMargin = targetExcessMargin;
            }
            // use default value if no "realisedPnl" provided
            if (realisedPnl == null)
            {
                this.RealisedPnl = 0;
            }
            else
            {
                this.RealisedPnl = realisedPnl;
            }
            // use default value if no "unrealisedPnl" provided
            if (unrealisedPnl == null)
            {
                this.UnrealisedPnl = 0;
            }
            else
            {
                this.UnrealisedPnl = unrealisedPnl;
            }
            // use default value if no "walletBalance" provided
            if (walletBalance == null)
            {
                this.WalletBalance = 0;
            }
            else
            {
                this.WalletBalance = walletBalance;
            }
            // use default value if no "marginBalance" provided
            if (marginBalance == null)
            {
                this.MarginBalance = 0;
            }
            else
            {
                this.MarginBalance = marginBalance;
            }
            // use default value if no "marginLeverage" provided
            if (marginLeverage == null)
            {
                this.MarginLeverage = 0.0;
            }
            else
            {
                this.MarginLeverage = marginLeverage;
            }
            // use default value if no "marginUsedPcnt" provided
            if (marginUsedPcnt == null)
            {
                this.MarginUsedPcnt = 0.0;
            }
            else
            {
                this.MarginUsedPcnt = marginUsedPcnt;
            }
            // use default value if no "excessMargin" provided
            if (excessMargin == null)
            {
                this.ExcessMargin = 0;
            }
            else
            {
                this.ExcessMargin = excessMargin;
            }
            // use default value if no "availableMargin" provided
            if (availableMargin == null)
            {
                this.AvailableMargin = 0;
            }
            else
            {
                this.AvailableMargin = availableMargin;
            }
            // use default value if no "withdrawableMargin" provided
            if (withdrawableMargin == null)
            {
                this.WithdrawableMargin = 0;
            }
            else
            {
                this.WithdrawableMargin = withdrawableMargin;
            }
            // use default value if no "makerFeeDiscount" provided
            if (makerFeeDiscount == null)
            {
                this.MakerFeeDiscount = 0.0;
            }
            else
            {
                this.MakerFeeDiscount = makerFeeDiscount;
            }
            // use default value if no "takerFeeDiscount" provided
            if (takerFeeDiscount == null)
            {
                this.TakerFeeDiscount = 0.0;
            }
            else
            {
                this.TakerFeeDiscount = takerFeeDiscount;
            }
            this.Timestamp = timestamp;
        }
        
        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public long? Account { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets RiskLimit
        /// </summary>
        [DataMember(Name="riskLimit", EmitDefaultValue=false)]
        public long? RiskLimit { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public long? Amount { get; set; }

        /// <summary>
        /// Gets or Sets PrevRealisedPnl
        /// </summary>
        [DataMember(Name="prevRealisedPnl", EmitDefaultValue=false)]
        public long? PrevRealisedPnl { get; set; }

        /// <summary>
        /// Gets or Sets GrossComm
        /// </summary>
        [DataMember(Name="grossComm", EmitDefaultValue=false)]
        public long? GrossComm { get; set; }

        /// <summary>
        /// Gets or Sets GrossOpenCost
        /// </summary>
        [DataMember(Name="grossOpenCost", EmitDefaultValue=false)]
        public long? GrossOpenCost { get; set; }

        /// <summary>
        /// Gets or Sets GrossOpenPremium
        /// </summary>
        [DataMember(Name="grossOpenPremium", EmitDefaultValue=false)]
        public long? GrossOpenPremium { get; set; }

        /// <summary>
        /// Gets or Sets GrossExecCost
        /// </summary>
        [DataMember(Name="grossExecCost", EmitDefaultValue=false)]
        public long? GrossExecCost { get; set; }

        /// <summary>
        /// Gets or Sets GrossMarkValue
        /// </summary>
        [DataMember(Name="grossMarkValue", EmitDefaultValue=false)]
        public long? GrossMarkValue { get; set; }

        /// <summary>
        /// Gets or Sets RiskValue
        /// </summary>
        [DataMember(Name="riskValue", EmitDefaultValue=false)]
        public long? RiskValue { get; set; }

        /// <summary>
        /// Gets or Sets InitMargin
        /// </summary>
        [DataMember(Name="initMargin", EmitDefaultValue=false)]
        public long? InitMargin { get; set; }

        /// <summary>
        /// Gets or Sets MaintMargin
        /// </summary>
        [DataMember(Name="maintMargin", EmitDefaultValue=false)]
        public long? MaintMargin { get; set; }

        /// <summary>
        /// Gets or Sets TargetExcessMargin
        /// </summary>
        [DataMember(Name="targetExcessMargin", EmitDefaultValue=false)]
        public long? TargetExcessMargin { get; set; }

        /// <summary>
        /// Gets or Sets RealisedPnl
        /// </summary>
        [DataMember(Name="realisedPnl", EmitDefaultValue=false)]
        public long? RealisedPnl { get; set; }

        /// <summary>
        /// Gets or Sets UnrealisedPnl
        /// </summary>
        [DataMember(Name="unrealisedPnl", EmitDefaultValue=false)]
        public long? UnrealisedPnl { get; set; }

        /// <summary>
        /// Gets or Sets WalletBalance
        /// </summary>
        [DataMember(Name="walletBalance", EmitDefaultValue=false)]
        public long? WalletBalance { get; set; }

        /// <summary>
        /// Gets or Sets MarginBalance
        /// </summary>
        [DataMember(Name="marginBalance", EmitDefaultValue=false)]
        public long? MarginBalance { get; set; }

        /// <summary>
        /// Gets or Sets MarginLeverage
        /// </summary>
        [DataMember(Name="marginLeverage", EmitDefaultValue=false)]
        public double? MarginLeverage { get; set; }

        /// <summary>
        /// Gets or Sets MarginUsedPcnt
        /// </summary>
        [DataMember(Name="marginUsedPcnt", EmitDefaultValue=false)]
        public double? MarginUsedPcnt { get; set; }

        /// <summary>
        /// Gets or Sets ExcessMargin
        /// </summary>
        [DataMember(Name="excessMargin", EmitDefaultValue=false)]
        public long? ExcessMargin { get; set; }

        /// <summary>
        /// Gets or Sets AvailableMargin
        /// </summary>
        [DataMember(Name="availableMargin", EmitDefaultValue=false)]
        public long? AvailableMargin { get; set; }

        /// <summary>
        /// Gets or Sets WithdrawableMargin
        /// </summary>
        [DataMember(Name="withdrawableMargin", EmitDefaultValue=false)]
        public long? WithdrawableMargin { get; set; }

        /// <summary>
        /// Gets or Sets MakerFeeDiscount
        /// </summary>
        [DataMember(Name="makerFeeDiscount", EmitDefaultValue=false)]
        public double? MakerFeeDiscount { get; set; }

        /// <summary>
        /// Gets or Sets TakerFeeDiscount
        /// </summary>
        [DataMember(Name="takerFeeDiscount", EmitDefaultValue=false)]
        public double? TakerFeeDiscount { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Margin {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  RiskLimit: ").Append(RiskLimit).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  PrevRealisedPnl: ").Append(PrevRealisedPnl).Append("\n");
            sb.Append("  GrossComm: ").Append(GrossComm).Append("\n");
            sb.Append("  GrossOpenCost: ").Append(GrossOpenCost).Append("\n");
            sb.Append("  GrossOpenPremium: ").Append(GrossOpenPremium).Append("\n");
            sb.Append("  GrossExecCost: ").Append(GrossExecCost).Append("\n");
            sb.Append("  GrossMarkValue: ").Append(GrossMarkValue).Append("\n");
            sb.Append("  RiskValue: ").Append(RiskValue).Append("\n");
            sb.Append("  InitMargin: ").Append(InitMargin).Append("\n");
            sb.Append("  MaintMargin: ").Append(MaintMargin).Append("\n");
            sb.Append("  TargetExcessMargin: ").Append(TargetExcessMargin).Append("\n");
            sb.Append("  RealisedPnl: ").Append(RealisedPnl).Append("\n");
            sb.Append("  UnrealisedPnl: ").Append(UnrealisedPnl).Append("\n");
            sb.Append("  WalletBalance: ").Append(WalletBalance).Append("\n");
            sb.Append("  MarginBalance: ").Append(MarginBalance).Append("\n");
            sb.Append("  MarginLeverage: ").Append(MarginLeverage).Append("\n");
            sb.Append("  MarginUsedPcnt: ").Append(MarginUsedPcnt).Append("\n");
            sb.Append("  ExcessMargin: ").Append(ExcessMargin).Append("\n");
            sb.Append("  AvailableMargin: ").Append(AvailableMargin).Append("\n");
            sb.Append("  WithdrawableMargin: ").Append(WithdrawableMargin).Append("\n");
            sb.Append("  MakerFeeDiscount: ").Append(MakerFeeDiscount).Append("\n");
            sb.Append("  TakerFeeDiscount: ").Append(TakerFeeDiscount).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as Margin);
        }

        /// <summary>
        /// Returns true if Margin instances are equal
        /// </summary>
        /// <param name="input">Instance of Margin to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Margin input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.RiskLimit == input.RiskLimit ||
                    (this.RiskLimit != null &&
                    this.RiskLimit.Equals(input.RiskLimit))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.PrevRealisedPnl == input.PrevRealisedPnl ||
                    (this.PrevRealisedPnl != null &&
                    this.PrevRealisedPnl.Equals(input.PrevRealisedPnl))
                ) && 
                (
                    this.GrossComm == input.GrossComm ||
                    (this.GrossComm != null &&
                    this.GrossComm.Equals(input.GrossComm))
                ) && 
                (
                    this.GrossOpenCost == input.GrossOpenCost ||
                    (this.GrossOpenCost != null &&
                    this.GrossOpenCost.Equals(input.GrossOpenCost))
                ) && 
                (
                    this.GrossOpenPremium == input.GrossOpenPremium ||
                    (this.GrossOpenPremium != null &&
                    this.GrossOpenPremium.Equals(input.GrossOpenPremium))
                ) && 
                (
                    this.GrossExecCost == input.GrossExecCost ||
                    (this.GrossExecCost != null &&
                    this.GrossExecCost.Equals(input.GrossExecCost))
                ) && 
                (
                    this.GrossMarkValue == input.GrossMarkValue ||
                    (this.GrossMarkValue != null &&
                    this.GrossMarkValue.Equals(input.GrossMarkValue))
                ) && 
                (
                    this.RiskValue == input.RiskValue ||
                    (this.RiskValue != null &&
                    this.RiskValue.Equals(input.RiskValue))
                ) && 
                (
                    this.InitMargin == input.InitMargin ||
                    (this.InitMargin != null &&
                    this.InitMargin.Equals(input.InitMargin))
                ) && 
                (
                    this.MaintMargin == input.MaintMargin ||
                    (this.MaintMargin != null &&
                    this.MaintMargin.Equals(input.MaintMargin))
                ) && 
                (
                    this.TargetExcessMargin == input.TargetExcessMargin ||
                    (this.TargetExcessMargin != null &&
                    this.TargetExcessMargin.Equals(input.TargetExcessMargin))
                ) && 
                (
                    this.RealisedPnl == input.RealisedPnl ||
                    (this.RealisedPnl != null &&
                    this.RealisedPnl.Equals(input.RealisedPnl))
                ) && 
                (
                    this.UnrealisedPnl == input.UnrealisedPnl ||
                    (this.UnrealisedPnl != null &&
                    this.UnrealisedPnl.Equals(input.UnrealisedPnl))
                ) && 
                (
                    this.WalletBalance == input.WalletBalance ||
                    (this.WalletBalance != null &&
                    this.WalletBalance.Equals(input.WalletBalance))
                ) && 
                (
                    this.MarginBalance == input.MarginBalance ||
                    (this.MarginBalance != null &&
                    this.MarginBalance.Equals(input.MarginBalance))
                ) && 
                (
                    this.MarginLeverage == input.MarginLeverage ||
                    (this.MarginLeverage != null &&
                    this.MarginLeverage.Equals(input.MarginLeverage))
                ) && 
                (
                    this.MarginUsedPcnt == input.MarginUsedPcnt ||
                    (this.MarginUsedPcnt != null &&
                    this.MarginUsedPcnt.Equals(input.MarginUsedPcnt))
                ) && 
                (
                    this.ExcessMargin == input.ExcessMargin ||
                    (this.ExcessMargin != null &&
                    this.ExcessMargin.Equals(input.ExcessMargin))
                ) && 
                (
                    this.AvailableMargin == input.AvailableMargin ||
                    (this.AvailableMargin != null &&
                    this.AvailableMargin.Equals(input.AvailableMargin))
                ) && 
                (
                    this.WithdrawableMargin == input.WithdrawableMargin ||
                    (this.WithdrawableMargin != null &&
                    this.WithdrawableMargin.Equals(input.WithdrawableMargin))
                ) && 
                (
                    this.MakerFeeDiscount == input.MakerFeeDiscount ||
                    (this.MakerFeeDiscount != null &&
                    this.MakerFeeDiscount.Equals(input.MakerFeeDiscount))
                ) && 
                (
                    this.TakerFeeDiscount == input.TakerFeeDiscount ||
                    (this.TakerFeeDiscount != null &&
                    this.TakerFeeDiscount.Equals(input.TakerFeeDiscount))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.RiskLimit != null)
                    hashCode = hashCode * 59 + this.RiskLimit.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.PrevRealisedPnl != null)
                    hashCode = hashCode * 59 + this.PrevRealisedPnl.GetHashCode();
                if (this.GrossComm != null)
                    hashCode = hashCode * 59 + this.GrossComm.GetHashCode();
                if (this.GrossOpenCost != null)
                    hashCode = hashCode * 59 + this.GrossOpenCost.GetHashCode();
                if (this.GrossOpenPremium != null)
                    hashCode = hashCode * 59 + this.GrossOpenPremium.GetHashCode();
                if (this.GrossExecCost != null)
                    hashCode = hashCode * 59 + this.GrossExecCost.GetHashCode();
                if (this.GrossMarkValue != null)
                    hashCode = hashCode * 59 + this.GrossMarkValue.GetHashCode();
                if (this.RiskValue != null)
                    hashCode = hashCode * 59 + this.RiskValue.GetHashCode();
                if (this.InitMargin != null)
                    hashCode = hashCode * 59 + this.InitMargin.GetHashCode();
                if (this.MaintMargin != null)
                    hashCode = hashCode * 59 + this.MaintMargin.GetHashCode();
                if (this.TargetExcessMargin != null)
                    hashCode = hashCode * 59 + this.TargetExcessMargin.GetHashCode();
                if (this.RealisedPnl != null)
                    hashCode = hashCode * 59 + this.RealisedPnl.GetHashCode();
                if (this.UnrealisedPnl != null)
                    hashCode = hashCode * 59 + this.UnrealisedPnl.GetHashCode();
                if (this.WalletBalance != null)
                    hashCode = hashCode * 59 + this.WalletBalance.GetHashCode();
                if (this.MarginBalance != null)
                    hashCode = hashCode * 59 + this.MarginBalance.GetHashCode();
                if (this.MarginLeverage != null)
                    hashCode = hashCode * 59 + this.MarginLeverage.GetHashCode();
                if (this.MarginUsedPcnt != null)
                    hashCode = hashCode * 59 + this.MarginUsedPcnt.GetHashCode();
                if (this.ExcessMargin != null)
                    hashCode = hashCode * 59 + this.ExcessMargin.GetHashCode();
                if (this.AvailableMargin != null)
                    hashCode = hashCode * 59 + this.AvailableMargin.GetHashCode();
                if (this.WithdrawableMargin != null)
                    hashCode = hashCode * 59 + this.WithdrawableMargin.GetHashCode();
                if (this.MakerFeeDiscount != null)
                    hashCode = hashCode * 59 + this.MakerFeeDiscount.GetHashCode();
                if (this.TakerFeeDiscount != null)
                    hashCode = hashCode * 59 + this.TakerFeeDiscount.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
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
