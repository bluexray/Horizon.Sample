using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectTiansuoQueryResponse.
    /// </summary>
    public class AntMerchantExpandIndirectTiansuoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 间连商户pid和对应名称信息
        /// </summary>
        [JsonPropertyName("indirect_isv_info")]
        public List<IndirectIsvInfo> IndirectIsvInfo { get; set; }
    }
}
