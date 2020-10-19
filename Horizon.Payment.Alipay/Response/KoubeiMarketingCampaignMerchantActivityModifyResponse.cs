﻿using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignMerchantActivityModifyResponse.
    /// </summary>
    public class KoubeiMarketingCampaignMerchantActivityModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 创建成功之后返回活动详情信息，包含活动activity_id和活动当前状态activity_status等信息。
        /// </summary>
        [JsonPropertyName("activity_detail_info")]
        public MActivityDetailInfo ActivityDetailInfo { get; set; }
    }
}
