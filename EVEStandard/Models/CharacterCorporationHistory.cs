﻿namespace EVEStandard.Models
{
    using System;
    using Newtonsoft.Json;

    public class CharacterCorporationHistory : ModelBase<CharacterCorporationHistory>
    {
        /// <summary>
        ///     start_date string
        /// </summary>
        /// <value>start_date string</value>
        [JsonProperty("start_date")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        ///     corporation_id integer
        /// </summary>
        /// <value>corporation_id integer</value>
        [JsonProperty("corporation_id")]
        public int? CorporationId { get; set; }

        /// <summary>
        ///     True if the corporation has been deleted
        /// </summary>
        /// <value>True if the corporation has been deleted</value>
        [JsonProperty("is_deleted")]
        public bool? IsDeleted { get; set; }

        /// <summary>
        ///     An incrementing ID that can be used to canonically establish order of records in cases where dates may be ambiguous
        /// </summary>
        /// <value>
        ///     An incrementing ID that can be used to canonically establish order of records in cases where dates may be
        ///     ambiguous
        /// </value>
        [JsonProperty("record_id")]
        public int? RecordId { get; set; }
    }
}