﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataActivityBillDownloadModel Data Structure.
    /// </summary>
    public class KoubeiMarketingDataActivityBillDownloadModel : AlipayObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }
    }
}
