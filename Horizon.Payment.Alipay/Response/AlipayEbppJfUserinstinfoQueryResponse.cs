using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppJfUserinstinfoQueryResponse.
    /// </summary>
    public class AlipayEbppJfUserinstinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 机构信息列表
        /// </summary>
        [JsonPropertyName("user_charge_inst_info_list")]
        public List<EbppUserChargeInstInfo> UserChargeInstInfoList { get; set; }
    }
}
