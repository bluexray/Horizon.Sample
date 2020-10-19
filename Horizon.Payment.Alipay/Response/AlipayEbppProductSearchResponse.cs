using System.Collections.Generic;
using System.Text.Json.Serialization;
using Horizon.Payment.Alipay.Domain;

namespace Horizon.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppProductSearchResponse.
    /// </summary>
    public class AlipayEbppProductSearchResponse : AlipayResponse
    {
        /// <summary>
        /// 产品(学校)模型列表
        /// </summary>
        [JsonPropertyName("exproductconfs")]
        public List<ExproductconfResponse> Exproductconfs { get; set; }
    }
}
