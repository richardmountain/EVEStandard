﻿using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace EVEStandard.Models
{
    public class Contract : ModelBase<Contract>
    {
        #region Enums

        /// <summary>
        /// To whom the contract is available
        /// </summary>
        /// <value>To whom the contract is available</value>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum AvailabilityEnum
        {
            [EnumMember(Value = "public")]
            publicEnum = 1,
            personal = 2,
            corporation = 3,
            alliance = 4
        }

        /// <summary>
        /// Status of the the contract
        /// </summary>
        /// <value>Status of the the contract</value>
        public enum StatusEnum
        {
            outstanding = 1,
            in_progress = 2,
            finished_issuer = 3,
            finished_contractor = 4,
            finished = 5,
            cancelled = 6,
            rejected = 7,
            failed = 8,
            deleted = 9,
            reversed = 10
        }

        /// <summary>
        /// Type of the contract
        /// </summary>
        /// <value>Type of the contract</value>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum TypeEnum
        {
            unknown = 1,
            item_exchange = 2,
            auction = 3,
            courier = 4,
            loan = 5
        }

        #endregion Enums

        #region Properties

        /// <summary>
        /// Who will accept the contract
        /// </summary>
        /// <value>Who will accept the contract</value>
        [JsonPropertyName("acceptor_id")]
        public int AcceptorId { get; set; }

        /// <summary>
        /// ID to whom the contract is assigned, can be corporation or character ID
        /// </summary>
        /// <value>ID to whom the contract is assigned, can be corporation or character ID</value>
        [JsonPropertyName("assignee_id")]
        public int AssigneeId { get; set; }

        /// <summary>
        /// To whom the contract is available
        /// </summary>
        /// <value>To whom the contract is available</value>
        [JsonPropertyName("availability")]
        public AvailabilityEnum Availability { get; set; }

        /// <summary>
        /// Buyout price (for Auctions only)
        /// </summary>
        /// <value>Buyout price (for Auctions only)</value>
        [JsonPropertyName("buyout")]
        public double? Buyout { get; set; }

        /// <summary>
        /// Collateral price (for Couriers only)
        /// </summary>
        /// <value>Collateral price (for Couriers only)</value>
        [JsonPropertyName("collateral")]
        public double? Collateral { get; set; }

        /// <summary>
        /// contract_id integer
        /// </summary>
        /// <value>contract_id integer</value>
        [JsonPropertyName("contract_id")]
        public int ContractId { get; set; }

        /// <summary>
        /// Date of confirmation of contract
        /// </summary>
        /// <value>Date of confirmation of contract</value>
        [JsonPropertyName("date_accepted")]
        public DateTime? DateAccepted { get; set; }

        /// <summary>
        /// Date of completed of contract
        /// </summary>
        /// <value>Date of completed of contract</value>
        [JsonPropertyName("date_completed")]
        public DateTime? DateCompleted { get; set; }

        /// <summary>
        /// Expiration date of the contract
        /// </summary>
        /// <value>Expiration date of the contract</value>
        [JsonPropertyName("date_expired")]
        public DateTime DateExpired { get; set; }

        /// <summary>
        /// Сreation date of the contract
        /// </summary>
        /// <value>Сreation date of the contract</value>
        [JsonPropertyName("date_issued")]
        public DateTime DateIssued { get; set; }

        /// <summary>
        /// Number of days to perform the contract
        /// </summary>
        /// <value>Number of days to perform the contract</value>
        [JsonPropertyName("days_to_complete")]
        public int? DaysToComplete { get; set; }

        /// <summary>
        /// End location ID (for Couriers contract)
        /// </summary>
        /// <value>End location ID (for Couriers contract)</value>
        [JsonPropertyName("end_location_id")]
        public long? EndLocationId { get; set; }

        /// <summary>
        /// true if the contract was issued on behalf of the issuer&#39;s corporation
        /// </summary>
        /// <value>true if the contract was issued on behalf of the issuer&#39;s corporation</value>
        [JsonPropertyName("for_corporation")]
        public bool ForCorporation { get; set; }

        /// <summary>
        /// Character&#39;s corporation ID for the issuer
        /// </summary>
        /// <value>Character&#39;s corporation ID for the issuer</value>
        [JsonPropertyName("issuer_corporation_id")]
        public int IssuerCorporationId { get; set; }

        /// <summary>
        /// Character ID for the issuer
        /// </summary>
        /// <value>Character ID for the issuer</value>
        [JsonPropertyName("issuer_id")]
        public int IssuerId { get; set; }
        /// <summary>
        /// Price of contract (for ItemsExchange and Auctions)
        /// </summary>
        /// <value>Price of contract (for ItemsExchange and Auctions)</value>
        [JsonPropertyName("price")]
        public double? Price { get; set; }

        /// <summary>
        /// Remuneration for contract (for Couriers only)
        /// </summary>
        /// <value>Remuneration for contract (for Couriers only)</value>
        [JsonPropertyName("reward")]
        public double? Reward { get; set; }

        /// <summary>
        /// Start location ID (for Couriers contract)
        /// </summary>
        /// <value>Start location ID (for Couriers contract)</value>
        [JsonPropertyName("start_location_id")]
        public long? StartLocationId { get; set; }
        /// <summary>
        /// Status of the the contract
        /// </summary>
        /// <value>Status of the the contract</value>
        [JsonPropertyName("status")]
        public StatusEnum Status { get; set; }

        /// <summary>
        /// Title of the contract
        /// </summary>
        /// <value>Title of the contract</value>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Type of the contract
        /// </summary>
        /// <value>Type of the contract</value>
        [JsonPropertyName("type")]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Volume of items in the contract
        /// </summary>
        /// <value>Volume of items in the contract</value>
        [JsonPropertyName("volume")]
        public double? Volume { get; set; }

        #endregion Properties
    }
}
