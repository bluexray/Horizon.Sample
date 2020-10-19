using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserPortraitQueryResponse.
    /// </summary>
    public class AlipayUserPortraitQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 拼团信息列表
        /// </summary>
        [JsonPropertyName("pintuan_user_infos")]
        public List<PintuanUserInfos> PintuanUserInfos { get; set; }
    }
}
