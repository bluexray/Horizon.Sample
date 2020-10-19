using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiServindustryPromoGuidequotaQueryResponse.
    /// </summary>
    public class KoubeiServindustryPromoGuidequotaQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 权限份额
        /// </summary>
        [JsonPropertyName("auth_quota")]
        public List<IgAuthQuota> AuthQuota { get; set; }
    }
}
