using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// MybankMarketingCampaignPrizeListQueryResponse.
    /// </summary>
    public class MybankMarketingCampaignPrizeListQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 奖品列表
        /// </summary>
        [JsonPropertyName("prize_list")]
        public List<PrizeModel> PrizeList { get; set; }

        /// <summary>
        /// 奖品总个数
        /// </summary>
        [JsonPropertyName("total_size")]
        public long TotalSize { get; set; }
    }
}
