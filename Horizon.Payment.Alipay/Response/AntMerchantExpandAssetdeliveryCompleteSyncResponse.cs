using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandAssetdeliveryCompleteSyncResponse.
    /// </summary>
    public class AntMerchantExpandAssetdeliveryCompleteSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 配送反馈处理结果
        /// </summary>
        [JsonPropertyName("delivery_results")]
        public List<AssetResult> DeliveryResults { get; set; }
    }
}
