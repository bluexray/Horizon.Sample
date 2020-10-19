﻿using System.Text.Json.Serialization;

namespace Horizon.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignQrcodeQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignQrcodeQueryModel : AlipayObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }
    }
}
